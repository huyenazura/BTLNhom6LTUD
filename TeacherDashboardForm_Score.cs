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
    public partial class TeacherDashboardForm_Score : Form
    {
        Ketnoi kn = new Ketnoi();
        private string currentViewName = "";
        private bool isFormLoaded = false;
        public TeacherDashboardForm_Score()
        {
            InitializeComponent();
        }
        public void Information_frofile(string hocky)
        {
            currentViewName = "View_DiemTrungBinh_hk" + hocky;

            string sql = $"SELECT*FROM {currentViewName} WHERE MaLop = '10A'";

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


        private void TeacherDashboardForm_Score_Load(object sender, EventArgs e)
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
