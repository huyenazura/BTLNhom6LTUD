using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6QuanLyDiemTHPT
{
    class Ketnoi
    {
        public SqlConnection cnn;//ket noi du lieu
        public SqlCommand cmd;//thuc thi cau lenh
        public DataTable dta;//doc du lieu
        public SqlDataAdapter ada;

        public void KetNoiDuLieu()
        {

           // string strKetNoi = @"Data Source=LAPTOP-MB3NTVOJ\SQLEXPRESS;Initial Catalog=QL_DIEM_THPT;Integrated Security=True;Integrated Security=True;Encrypt=False";
            string strKetNoi = @"Data Source=DESKTOP-LQO0Q4M\MSSQLSERVER01;Initial Catalog=QL_DIEM_THPT_version_2;Integrated Security=True;Integrated Security=True;Encrypt=False";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }
        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataTable Lay_DuLieuBang(string Sql, List<SqlParameter> parameters = null)
        {
            KetNoiDuLieu();
            cmd = new SqlCommand(Sql, cnn);
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
            }
            ada = new SqlDataAdapter(cmd);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;

        }

        public void ThucThi(string sql)
        {
            KetNoiDuLieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
       
        // Thêm phương thức để lấy đối tượng SqlConnection
        public SqlConnection GetConnection()
        {
            return cnn;
        }
    }

}
