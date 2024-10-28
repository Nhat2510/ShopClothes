using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanQuanAo.DAL
{
    internal class Dal_DangNhap
    {
        LopDungChung lopChung;
        public Dal_DangNhap()
        {
            lopChung = new LopDungChung();
        }
        public int Dal_Dn(String tenDn,String Mk)
        {
            string sqlDN = "select count(*) from TAIKHOAN where TenDangNhap='" + tenDn + "' and MatKhau='" + Mk + "'";
            int kq = (int)lopChung.Scalar(sqlDN);
            return kq;
        }
    }
}
