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
    public partial class StudentManager : Form
    {
        Ketnoi kn = new Ketnoi();
        private DataTable dtHocSinh;
        private bool dangSua = false;
        private bool isAddingNew = false;
        public StudentManager()
        {
            InitializeComponent();
            InitializeComboboxes();
            LoadData();
        }
        private void LoadData()
        {
            dtHocSinh = kn.Lay_DuLieuBang("SELECT * FROM HocSinh");
            dataGridViewDiem.DataSource = dtHocSinh;
            dataGridViewDiem.ReadOnly = true;
            isAddingNew = false;
            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";
        }

        private void InitializeComboboxes()
        {
            // cbLop từ HocSinh.MaLop
            var dtLop = kn.Lay_DuLieuBang("SELECT DISTINCT MaLop FROM HocSinh");
            cbLop.DataSource = dtLop;
            cbLop.DisplayMember = "MaLop";
            cbLop.ValueMember = "MaLop";
            cbLop.SelectedIndex = -1;

            // cbNamHoc từ NamHoc_HocKy.NamHoc
            var dtNam = kn.Lay_DuLieuBang("SELECT DISTINCT NamHoc FROM NamHoc_HocKy");
            cbNamHoc.DataSource = dtNam;
            cbNamHoc.DisplayMember = "NamHoc";
            cbNamHoc.ValueMember = "NamHoc";
            cbNamHoc.SelectedIndex = -1;

            // cbKyHoc từ NamHoc_HocKy.HocKy
            var dtKy = kn.Lay_DuLieuBang("SELECT DISTINCT HocKy FROM NamHoc_HocKy");
            cbKyHoc.DataSource = dtKy;
            cbKyHoc.DisplayMember = "HocKy";
            cbKyHoc.ValueMember = "HocKy";
            cbKyHoc.SelectedIndex = -1;
        }
        private void StudentManager_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var conds = new List<string>();
            var ps = new List<SqlParameter>();

            // txtTimThongTin: tìm MaHocSinh hoặc HoTen
            string key = txtTimThongTin.Text.Trim();
            if (!string.IsNullOrEmpty(key))
            {
                conds.Add("(MaHocSinh = @key OR HoTen LIKE '%' + @key + '%')");
                ps.Add(new SqlParameter("@key", key));
            }

            // cbLop
            if (cbLop.SelectedIndex >= 0)
            {
                conds.Add("MaLop = @lop");
                ps.Add(new SqlParameter("@lop", cbLop.SelectedValue));
            }

            // cbNamHoc + cbKyHoc => lọc qua bảng BangDiem
            if (cbNamHoc.SelectedIndex >= 0 && cbKyHoc.SelectedIndex >= 0)
            {
                conds.Add("MaHocSinh IN (" +
                          "SELECT MaHocSinh FROM BangDiem bd " +
                          "JOIN NamHoc_HocKy nhk ON bd.MaHocKy = nhk.MaHocKy " +
                          "WHERE nhk.NamHoc = @nam AND nhk.HocKy = @ky" +
                          ")");
                ps.Add(new SqlParameter("@nam", cbNamHoc.SelectedValue));
                ps.Add(new SqlParameter("@ky", cbKyHoc.SelectedValue));
            }

            string where = conds.Count > 0
                ? "WHERE " + string.Join(" AND ", conds)
                : "";

            dtHocSinh = kn.Lay_DuLieuBang($"SELECT * FROM HocSinh {where}", ps);
            dataGridViewDiem.DataSource = dtHocSinh;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 học sinh để xóa.");
                return;
            }

            string ma = dataGridViewDiem.SelectedRows[0].Cells["MaHocSinh"].Value.ToString();
            if (MessageBox.Show($"Xóa HS {ma}?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            kn.ThucThi($"DELETE FROM HocSinh WHERE MaHocSinh = N'{ma}'");
            LoadData();
            MessageBox.Show("Xóa thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!isAddingNew)
            {
                if (dataGridViewDiem.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Chọn 1 học sinh để sửa.");
                    return;
                }
                // Cho phép edit trực tiếp
                dataGridViewDiem.ReadOnly = false;
                dataGridViewDiem.BeginEdit(true);
                btnSua.Text = "Lưu";
                isAddingNew = true;  // tái sử dụng biến để nhận biết đang ở trạng thái sửa
            }
            else
            {
                // Lưu sửa
                dataGridViewDiem.EndEdit();
                var row = dataGridViewDiem.SelectedRows[0];

                string ma = row.Cells["MaHocSinh"].Value.ToString();
                string ten = row.Cells["HoTen"].Value.ToString();
                string ns = Convert.ToDateTime(row.Cells["NgaySinh"].Value).ToString("yyyy-MM-dd");
                string gt = row.Cells["GioiTinh"].Value.ToString();
                string dc = row.Cells["DiaChi"].Value.ToString();
                string sdt = row.Cells["SoDienThoai"].Value.ToString();
                string lop = row.Cells["MaLop"].Value.ToString();

                string sql = @"
UPDATE HocSinh SET
    HoTen = @ten, NgaySinh = @ns, GioiTinh = @gt,
    DiaChi = @dc, SoDienThoai = @sdt, MaLop = @lop
WHERE MaHocSinh = @ma";

                var ps = new List<SqlParameter>
                {
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", ten),
                    new SqlParameter("@ns", ns),
                    new SqlParameter("@gt", gt),
                    new SqlParameter("@dc", dc),
                    new SqlParameter("@sdt", sdt),
                    new SqlParameter("@lop", lop)
                };
                kn.ThucThi(sql
                    .Replace("@ma", $"N'{ma}'")
                    .Replace("@ten", $"N'{ten}'")
                    .Replace("@ns", $"'{ns}'")
                    .Replace("@gt", $"N'{gt}'")
                    .Replace("@dc", $"N'{dc}'")
                    .Replace("@sdt", $"'{sdt}'")
                    .Replace("@lop", $"N'{lop}'")
                );

                MessageBox.Show("Cập nhật thành công.");
                LoadData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isAddingNew)
            {
                // Thêm dòng trống vào DataTable
                var newRow = dtHocSinh.NewRow();
                dtHocSinh.Rows.Add(newRow);
                dataGridViewDiem.DataSource = dtHocSinh;
                dataGridViewDiem.CurrentCell = dataGridViewDiem.Rows[dataGridViewDiem.Rows.Count - 1].Cells[0];
                dataGridViewDiem.ReadOnly = false;
                btnThem.Text = "Lưu";
                isAddingNew = true;
                MessageBox.Show("Nhập đầy đủ thông tin lên dòng mới rồi nhấn 'Lưu'.");
            }
            else
            {
                // Lưu dòng mới
                var row = dtHocSinh.Rows[dtHocSinh.Rows.Count - 1];
                // Validate
                foreach (var col in new[] { "MaHocSinh", "HoTen", "NgaySinh", "GioiTinh", "DiaChi", "SoDienThoai", "MaLop" })
                {
                    if (row.IsNull(col) || string.IsNullOrWhiteSpace(row[col].ToString()))
                    {
                        MessageBox.Show($"Thiếu trường {col}. Vui lòng nhập đầy đủ.");
                        return;
                    }
                }

                string sql = $@"
INSERT INTO HocSinh
    (MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaLop)
VALUES
    (N'{row["MaHocSinh"]}', N'{row["HoTen"]}', '{Convert.ToDateTime(row["NgaySinh"]):yyyy-MM-dd}',
     N'{row["GioiTinh"]}', N'{row["DiaChi"]}', '{row["SoDienThoai"]}', N'{row["MaLop"]}')";

                try
                {
                    kn.ThucThi(sql);
                    MessageBox.Show("Thêm mới thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }

                LoadData();
            }
        }
    }
}