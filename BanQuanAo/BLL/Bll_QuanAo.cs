using BanQuanAo.GUI;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanQuanAo.BLL
{
    internal class Bll_QuanAo
    {
        DAL.Dal_QuanAo dal_quanAo;
        frm_QLBH QA;
        public Bll_QuanAo(frm_QLBH FQA)
        {
            dal_quanAo = new DAL.Dal_QuanAo();
            QA = FQA;
        }

        public void bll_Grid()
        {
            QA.dataGridView1.DataSource = dal_quanAo.dal_Grid();
        }
        
        public void bll_ComBo()
        {
            QA.cb_loaiSP.DataSource = dal_quanAo.dal_comBo();
            QA.cb_loaiSP.DisplayMember = "TenLoai";
            QA.cb_loaiSP.ValueMember = "MaLoai";
        }

        public void bll_sortCB()
        {
            QA.dataGridView1.DataSource = dal_quanAo.dal_sortCb(QA.cb_loaiSP.SelectedValue.ToString());
        }

        public void bll_tim()
        {
            String tim = Interaction.InputBox("Nhập thông tin cần tìm");
            QA.dataGridView1.DataSource = dal_quanAo.dal_tim(tim, tim);
        }

        public void bll_them()
        {
            dal_quanAo.dal_them(QA.txt_maSP.Text, QA.txt_tenSP.Text, QA.txt_Gia.Text, QA.dt_ngayNhap.Text,
                QA.txt_soLuong.Text, QA.cb_loaiSP.SelectedValue.ToString(), QA.txt_tenHinh.Text);
        }
        public void bll_sua()
        {
            dal_quanAo.dal_sua(QA.txt_maSP.Text, QA.txt_tenSP.Text, QA.txt_Gia.Text, QA.dt_ngayNhap.Text,
                QA.txt_soLuong.Text, QA.cb_loaiSP.SelectedValue.ToString(), QA.txt_tenHinh.Text);
        }
        public void bll_xoa()
        {
            dal_quanAo.dal_xoa(QA.txt_maSP.Text);
        }
    }
}
