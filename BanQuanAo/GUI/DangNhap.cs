using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BanQuanAo.DAL;

namespace BanQuanAo.GUI
{
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
            con = new SqlConnection(kn);
            bll_DN = new BLL.Bll_DangNhap(this);
        }
        string kn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\School\CS-464-HIS\DoAn\BanQuanAo\BanQuanAo\QLBH.mdf;Integrated Security=True";
        SqlConnection con;
        BLL.Bll_DangNhap bll_DN;
        private void btn_dn_Click(object sender, EventArgs e)
        {
            bll_DN.bll_DangNhap();
            txt_tenDn.Clear();
            txt_mk.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_tenDn.Clear();
            txt_mk.Clear();
        }

        private void frmDN_FormClosing(object sender, FormClosingEventArgs e)
        {
                DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                    e.Cancel = true;
        }
    }
}
