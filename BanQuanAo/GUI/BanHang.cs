using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanQuanAo.GUI
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
            bll_BanHang = new BLL.Bll_BanHang(this);
        }
        BLL.Bll_BanHang bll_BanHang;
        private void BanHang_Load(object sender, EventArgs e)
        {
            bll_BanHang.bll_Grid();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            bll_BanHang.bll_tim();
        }
        private DataGridViewRow selectedRow;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dataGridView1.Rows[e.RowIndex];
        }
        public void tinh_tong()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow) 
                {
                    double gia = 0;
                    double soLuong = 0;
                    if (row.Cells[2].Value != null && row.Cells[4].Value != null)
                    {
                        double.TryParse(row.Cells[2].Value.ToString(), out gia);
                        double.TryParse(row.Cells[4].Value.ToString(), out soLuong);
                    }
                    total += gia * soLuong;
                }
            }

            txtTotal.Text = total.ToString();
        }
        private void btn_tao_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                string selectedProductCode = selectedRow.Cells[0].Value.ToString();
                if ((int)selectedRow.Cells[4].Value == 0)
                {
                    MessageBox.Show("Hết hàng");
                    return;
                }
                bool duplicateFound = false;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == selectedProductCode)
                    {
                        duplicateFound = true;
                        break;
                    }
                }
                
                if (!duplicateFound)
                {
                    object[] rowData = new object[5];
                    for (int i = 0; i < 4; i++)
                    {
                        rowData[i] = selectedRow.Cells[i].Value;
                    }
                    rowData[4] = 1;
                    dataGridView2.Rows.Add(rowData);
                    tinh_tong();

                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại trong DataGridView2.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trước khi thêm vào DataGridView2.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView2.CurrentCell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow editedRow = dataGridView2.Rows[e.RowIndex];

            if (e.ColumnIndex == 4)
            {
                int quantity = 0;
                if (int.TryParse(editedRow.Cells[4].Value.ToString(), out quantity))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            String maSP = row.Cells[0].Value.ToString();
                            int soLuong = (int)row.Cells[4].Value;
                            if (maSP==editedRow.Cells[0].Value.ToString() &&quantity > soLuong)
                            {
                                MessageBox.Show("Quá số lượng hàng trong kho");
                                editedRow.Cells[4].Value = soLuong;
                                tinh_tong();
                                return;
                            }
                        }
                    }
                    tinh_tong();

                }
                else
                {
                    MessageBox.Show("Giá trị số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            bll_BanHang.bll_updatePay();
            dataGridView2.Rows.Clear();
        }

    }
}
