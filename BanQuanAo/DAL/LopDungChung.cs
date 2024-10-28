using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BanQuanAo.DAL
{
    internal class LopDungChung
    {
        public LopDungChung()
        {
            con = new SqlConnection(kn);
        }
        SqlConnection con;
        string kn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\School\CS-464-HIS\DoAn\BanQuanAo\BanQuanAo\QLBH.mdf;Integrated Security=True";

        public DataTable LoadDuLieu(String sqlDL)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlDL,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public Object Scalar(String sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, con);
            con.Open();
            int kq = (int)comm.ExecuteScalar();
            con.Close();
            return kq;
        }

        public void Nonquery(String sqlNonquery)
        {
            SqlCommand comm = new SqlCommand(sqlNonquery, con);
            con.Open();
            int kq = comm.ExecuteNonQuery();
            con.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
        
        
    }
}
