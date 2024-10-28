using BanQuanAo.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanQuanAo.BLL
{
    class Bll_DangNhap
    {
        DAL.Dal_DangNhap dal_dn;
        frmDN DN;
        public Bll_DangNhap(frmDN FDN)
        {
            dal_dn = new DAL.Dal_DangNhap();
            DN = FDN;
        }
        int soLan=3;
        public void bll_DangNhap()
        {
            int kq = dal_dn.Dal_Dn(DN.txt_tenDn.Text, DN.txt_mk.Text);
            if (kq >= 1)
            {
                soLan = 0;
                //frm_QLBH ql = new frm_QLBH();
                frmList list = new frmList();
                DN.Visible = false;
                list.ShowDialog();
                DN.Visible = true;
            }
            else
            {
                soLan = soLan - 1;
                MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu còn " + soLan+" thoát chương trình");
                if (soLan == 0)
                {
                    DN.Close();
                }
            }
        }
    }
}
