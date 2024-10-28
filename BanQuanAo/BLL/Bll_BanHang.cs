using BanQuanAo.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanQuanAo.BLL
{
    class Bll_BanHang
    {
        DAL.Dal_QuanAo dal_quanAo;
        frmBanHang BH;
        public Bll_BanHang( frmBanHang FBH)
        {
            dal_quanAo = new DAL.Dal_QuanAo();
            BH = FBH;
        }
        public void bll_Grid()
        {
            BH.dataGridView1.DataSource = dal_quanAo.dal_Grid();
        }
        public void bll_tim()
        {
            BH.dataGridView1.DataSource = dal_quanAo.dal_tim(BH.txt_tim.Text, BH.txt_tim.Text);
        }
        public void bll_updatePay()
        {
            foreach (DataGridViewRow row in BH.dataGridView2.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    String maSP = row.Cells[0].Value.ToString();
                    String soLuong = row.Cells[4].Value.ToString();
                    dal_quanAo.dal_updateThanhToan(maSP, soLuong);
                }
            }
            BH.dataGridView1.DataSource = dal_quanAo.dal_Grid();
        }
    }
}
