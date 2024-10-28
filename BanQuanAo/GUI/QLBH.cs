using BanQuanAo.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanQuanAo.GUI
{
    public partial class frm_QLBH : Form
    {
        public frm_QLBH()
        {
            InitializeComponent();
            lopChung = new LopDungChung();
            bll_QuanAo = new BLL.Bll_QuanAo(this);
        }

        BLL.Bll_QuanAo bll_QuanAo;
        LopDungChung lopChung;
        int chon=0;
        string duongDan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        public void LoadData()
        {
            bll_QuanAo.bll_Grid();
        }

        public void LoadLoai()
        {
            bll_QuanAo.bll_ComBo();
        }

        private void frm_QLBH_Load(object sender, EventArgs e)
        {
            LoadLoai();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maSP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tenSP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dt_ngayNhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_soLuong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            chon = 1;
            cb_loaiSP.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_tenHinh.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.ImageLocation = duongDan + txt_tenHinh.Text;
        }

        private void cb_loaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chon == 0)
            {
                bll_QuanAo.bll_sortCB();
            }
            chon = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ODF = new OpenFileDialog();
            ODF.Title = "Hãy chọn ảnh";
            ODF.Filter = "Tất cả đuôi|*.*|JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            if (ODF.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ODF.FileName);
            }
        }

        public void resetData()
        {
            txt_maSP.Clear();
            txt_tenSP.Clear();
            txt_Gia.Clear();
            dt_ngayNhap.Value = DateTime.Now;
            txt_soLuong.Clear();
            txt_tenHinh.Clear();
            pictureBox1.Image = null;
        }
        private void btn_loadd_Click(object sender, EventArgs e)
        {
            LoadData();
            resetData();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            bll_QuanAo.bll_tim();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(duongDan + txt_tenHinh.Text);
                bll_QuanAo.bll_them();
                resetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại vui lòng xem lại thông tin");
            }
            finally
            {
                LoadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(duongDan + txt_tenHinh.Text);
                bll_QuanAo.bll_sua();
                resetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại vui lòng xem lại thông tin");
            }
            finally
            {
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            File.Delete(duongDan + txt_tenHinh.Text);
            bll_QuanAo.bll_xoa();
            resetData();
            LoadData();
        }
        int tat = 0;
        private void frm_QLBH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tat == 0)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
