using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom6QuanLyDiemTHPT
{
    public partial class TeacherDashboardForm_Profile : Form
    {
        Ketnoi kn = new Ketnoi();

        public TeacherDashboardForm_Profile()
        {
            InitializeComponent();
        }


        public void Information_frofile()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("exec P_TimHocSinhTheoGVCN 'GV001'");
            dataGridViewDiem.DataSource = dta;
        }

        private void TeacherDashboardForm_Profile_Load(object sender, EventArgs e)
        {
            Information_frofile();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtTimThongTin.Text.Trim();
            DataTable dta = new DataTable();

            if (string.IsNullOrEmpty(searchText))
            {
                dta = kn.Lay_DuLieuBang("SELECT * FROM HocSinh");
            }
            else
            {
                string sql = "SELECT * FROM HocSinh WHERE MaHocSinh = @MaHocSinh OR HoTen LIKE '%' + @HoTen + '%'";
                var parameters = new List<SqlParameter>
        {
            new SqlParameter("@MaHocSinh", searchText),
            new SqlParameter("@HoTen", searchText)
        };

                dta = kn.Lay_DuLieuBang(sql, parameters);
            }

            dataGridViewDiem.DataSource = dta;
        }
    }
}
