using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom6QuanLyDiemTHPT
{
    public partial class SubjectTeacherForm : Form
    {
        Ketnoi kn = new Ketnoi();

        public SubjectTeacherForm()
        {
            InitializeComponent();
        }

        public void HocKi()
        {
            DataTable dta = kn.Lay_DuLieuBang("SELECT * FROM NamHoc_HocKy");
            cbHocKy.DataSource = dta;
            cbHocKy.DisplayMember = "HocKy";
            cbHocKy.ValueMember = "HocKy";

        }

        public void MaMon()
        {
            DataTable dta = kn.Lay_DuLieuBang("SELECT * FROM MonHoc");
            cboMaMon.DataSource = dta;
            cboMaMon.DisplayMember = "MaMonHoc";
            cboMaMon.ValueMember = "MaMonHoc";

        }

        public void Lop()
        {
            DataTable dta = kn.Lay_DuLieuBang("SELECT * FROM LopHoc");
            cbLop.DataSource = dta;
            cbLop.DisplayMember = "MaLop";
            cbLop.ValueMember = "MaLop";

        }

        public void LocBangDiemTheoBoLoc()
        {
            Console.WriteLine("LocBangDiemTheoBoLoc được gọi lúc: " + DateTime.Now.ToString("HH:mm:ss.fff"));

            if (cbHocKy.SelectedValue == null || cbLop.SelectedValue == null || cboMaMon.SelectedValue == null)
                return;

            string hocKy = cbHocKy.SelectedValue.ToString();
            string maLop = cbLop.SelectedValue.ToString();
            string maMon = cboMaMon.SelectedValue.ToString();

            string sql = "SELECT * FROM V_BangDiemChiTiet WHERE HocKy = @HocKy AND MaLop = @MaLop AND MaMonHoc = @MaMonHoc";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@HocKy", hocKy),
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@MaMonHoc", maMon)
            };

            DataTable dta = kn.Lay_DuLieuBang(sql, parameters);
            dataGridViewDiem.DataSource = dta;
        }

        private void SubjectTeacherForm_Load(object sender, EventArgs e)
        {
            HocKi();
            MaMon();
            Lop();

            cbHocKy.SelectedIndexChanged += ComboBoxFilterChanged;
            cbLop.SelectedIndexChanged += ComboBoxFilterChanged;
            cboMaMon.SelectedIndexChanged += ComboBoxFilterChanged;

            // Gọi lọc mặc định khi form load xong
            this.BeginInvoke(new Action(() =>
            {
                LocBangDiemTheoBoLoc();
            }));
        }

        private void ComboBoxFilterChanged(object sender, EventArgs e)
        {
            LocBangDiemTheoBoLoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbHocKy.SelectedValue == null || cbLop.SelectedValue == null || cboMaMon.SelectedValue == null)
                return;

            string hocKy = cbHocKy.SelectedValue.ToString();
            string maLop = cbLop.SelectedValue.ToString();
            string maMon = cboMaMon.SelectedValue.ToString();
            string tuKhoa = txtTimKiem.Text.Trim();

            string sql = @"SELECT * FROM V_BangDiemChiTiet 
                   WHERE HocKy = @HocKy AND MaLop = @MaLop AND MaMonHoc = @MaMonHoc 
                   AND (MaHocSinh LIKE @TuKhoa OR TenHocSinh LIKE @TuKhoa)";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@HocKy", hocKy),
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@MaMonHoc", maMon),
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%") // Sử dụng LIKE cho tìm kiếm
            };

            DataTable dta = kn.Lay_DuLieuBang(sql, parameters);
            dataGridViewDiem.DataSource = dta;
        }
    }
}
