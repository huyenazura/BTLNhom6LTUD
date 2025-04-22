using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom6QuanLyDiemTHPT
{
    public partial class TeacherDashboardForm_Behavior : Form
    {
        Ketnoi kn = new Ketnoi();
        private string currentViewName = "";
        private bool isFormLoaded = false; // Cờ để kiểm soát sự kiện SelectedIndexChanged

        public TeacherDashboardForm_Behavior()
        {
            InitializeComponent();
        }

        // Phương thức để lấy dữ liệu điểm trung bình học kỳ
        public void Information_frofile(string hocky)
        {
            currentViewName = "View_DiemTrungBinh_HK" + hocky;

            string sql = $"SELECT MaHocSinh, HoTen, HanhKiem, MaLop FROM {currentViewName} WHERE MaLop = '10A'";

            DataTable dta = kn.Lay_DuLieuBang(sql);
            dataGridViewDiem.DataSource = dta;
        }

        // Phương thức để lấy danh sách học kỳ
        public void HocKi()
        {
            DataTable dta = kn.Lay_DuLieuBang("SELECT * FROM NamHoc_HocKy");
            cbKyHoc.DataSource = dta;
            cbKyHoc.DisplayMember = "HocKy";
            cbKyHoc.ValueMember = "HocKy";
        }

        // Sự kiện khi người dùng chọn học kỳ
        private void cbKyHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ xử lý khi form đã load xong
            if (!isFormLoaded) return;

            if (cbKyHoc.SelectedItem != null)
            {
                DataRowView row = cbKyHoc.SelectedItem as DataRowView;
                string hocKy = row["HocKy"].ToString();
                Information_frofile(hocKy); // Cập nhật thông tin theo học kỳ được chọn
            }
        }

        // Sự kiện khi form được load
        private void TeacherDashboardForm_Behavior_Load(object sender, EventArgs e)
        {
            HocKi(); // Load dữ liệu học kỳ

            // Đánh dấu là đã load xong form
            isFormLoaded = true;

            // Nếu có item trong ComboBox, tự động chọn học kỳ mặc định và load dữ liệu
            if (cbKyHoc.Items.Count > 0)
            {
                string hocKyMacDinh = cbKyHoc.SelectedValue?.ToString() ?? "HK1";
                Information_frofile(hocKyMacDinh); // Tải dữ liệu cho học kỳ mặc định
            }
        }

        // Sự kiện khi người dùng tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtTimThongTin.Text.Trim();
            DataTable dta = new DataTable();

            // Kiểm tra xem học kỳ đã được chọn hay chưa
            if (string.IsNullOrEmpty(currentViewName))
            {
                MessageBox.Show("Vui lòng chọn học kỳ trước khi tìm kiếm!");
                return;
            }

            // Nếu không có từ khóa tìm kiếm, lấy tất cả dữ liệu
            if (string.IsNullOrEmpty(searchText))
            {
                dta = kn.Lay_DuLieuBang($"SELECT * FROM {currentViewName}");
            }
            else
            {
                // Nếu có từ khóa tìm kiếm, tìm theo mã học sinh hoặc tên học sinh
                string sql = $"SELECT * FROM {currentViewName} WHERE MaHocSinh = @MaHocSinh OR HoTen LIKE '%' + @HoTen + '%'";
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
