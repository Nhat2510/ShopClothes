using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanQuanAo.DAL
{
    internal class Dal_QuanAo
    {
        LopDungChung lopChung;
        public Dal_QuanAo()
        {
            lopChung = new LopDungChung();
        }

        public DataTable dal_Grid()
        {
            string sqlDL = "select * from QUANAO";
            return lopChung.LoadDuLieu(sqlDL);
        }

        public DataTable dal_comBo()
        {
            string sqlCB = "select * from LOAI";
            return lopChung.LoadDuLieu(sqlCB);
        }

        public DataTable dal_sortCb(String maLoai)
        {
            string sqlSort = "select * from QUANAO where MaLoai='" + maLoai + "'";
            return lopChung.LoadDuLieu(sqlSort);
        }

        public DataTable dal_tim(String maSP,String tenSP)
        {
            string sqlTim = "select * from QUANAO where MaSP like '%" + maSP + "%' or TenSP like N'%"+tenSP+"%'";
            return lopChung.LoadDuLieu(sqlTim);
        }

        public void dal_them(String maSP, String tenSP,String gia, String ngayNhap,String soLuong,String MaLoai,String TenHinh)
        {
            string sqlThem = "insert into QUANAO values('" + maSP + "',N'" + tenSP + "'," + gia
                + ",Convert(Datetime,'" + ngayNhap + "',103),"  + soLuong + ",'" + MaLoai + "',N'" + TenHinh + "')";
            lopChung.Nonquery(sqlThem);
        }

        public void dal_sua(String maSP, String tenSP, String gia, String ngayNhap, String soLuong, String MaLoai, String TenHinh)
        {
            String sqlSua = "update QUANAO set TenSP= N'" + tenSP+ "', Gia=" +gia +
                ",NgayNhap = Convert(Datetime,'" + ngayNhap + "', 103), " +
                "SoLuong = " + soLuong+ ", MaLoai= '" + MaLoai+ "',"+
                "TenHinh = '" + TenHinh + "' where MaSP = '" + maSP + "' ";
            lopChung.Nonquery(sqlSua);
        }

        public void dal_xoa(String maSP)
        {
            String sqlXoa = "delete from QUANAO where MaSP='" + maSP + "'";
            lopChung.Nonquery(sqlXoa);
        }

        public void dal_updateThanhToan(String maSP, String soLuong)
        {
            String sqlupdatePay = "update QUANAO set SoLuong = SoLuong - " + soLuong + " where MaSP='" + maSP + "'";
            lopChung.Nonquery(sqlupdatePay);
        }
    }
}
