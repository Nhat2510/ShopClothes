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
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banHang();
        }

        public void capNhat()
        {
            frm_QLBH ql = new frm_QLBH();
            this.Visible = false;
            ql.ShowDialog();
            this.Visible = true;
        }
        public void banHang()
        {
            frmBanHang bh = new frmBanHang();
            this.Visible = false;
            bh.ShowDialog();
            this.Visible = true;
        }
        private void cậpNhậtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capNhat();
        }

        private void btn_PageCapNhat_Click(object sender, EventArgs e)
        {
            capNhat();
        }

        private void btn_PageBanHang_Click(object sender, EventArgs e)
        {
            banHang();
        }

        private void frmList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.No)
                e.Cancel = true;
        }
    }
}
