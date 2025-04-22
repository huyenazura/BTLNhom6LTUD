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
    public partial class TeacherManager : Form
    {
        private Ketnoi kn = new Ketnoi();
        private DataTable dtGiaoVien;
        private bool isAddingNew = false;
        private bool isEditing = false;
        public TeacherManager()
        {
            InitializeComponent();
            LoadData();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dataGridViewDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDiem.MultiSelect = false;
            dataGridViewDiem.ReadOnly = true;
            dataGridViewDiem.AutoGenerateColumns = true;
        }

        private void LoadData()
        {
            dtGiaoVien = kn.Lay_DuLieuBang("SELECT * FROM GiaoVien");
            dataGridViewDiem.DataSource = dtGiaoVien;

            // reset state
            isAddingNew = isEditing = false;
            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";
        }

        private void TeacherManager_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimThongTin.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                LoadData();
                return;
            }

            var conds = new List<string>();
            var ps = new List<SqlParameter>();

            conds.Add(@"( MaGiaoVien = @key
                       OR HoTen       LIKE '%' + @key + '%'
                       OR GioiTinh    = @key
                       OR SoDienThoai = @key
                       OR Email       = @key
                       OR DiaChi      LIKE '%' + @key + '%' )");
            ps.Add(new SqlParameter("@key", key));

            string where = "WHERE " + string.Join(" AND ", conds);
            string sql = $"SELECT * FROM GiaoVien {where}";
            dtGiaoVien = kn.Lay_DuLieuBang(sql, ps);
            dataGridViewDiem.DataSource = dtGiaoVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isAddingNew)
            {
                // thêm dòng mới vào DataTable (không sửa trực tiếp Rows của dgv)
                var newRow = dtGiaoVien.NewRow();
                dtGiaoVien.Rows.Add(newRow);
                dataGridViewDiem.DataSource = dtGiaoVien;
                dataGridViewDiem.CurrentCell = dataGridViewDiem.Rows[dataGridViewDiem.Rows.Count - 1].Cells[0];
                dataGridViewDiem.ReadOnly = false;

                isAddingNew = true;
                btnThem.Text = "Lưu";
                MessageBox.Show("Nhập đầy đủ thông tin giáo viên lên dòng mới rồi nhấn 'Lưu'.");
            }
            else
            {
                // lưu mới
                var row = dtGiaoVien.Rows[dtGiaoVien.Rows.Count - 1];
                foreach (var col in new[] { "MaGiaoVien", "HoTen", "NgaySinh", "GioiTinh", "SoDienThoai", "Email", "DiaChi" })
                {
                    if (row.IsNull(col) || string.IsNullOrWhiteSpace(row[col].ToString()))
                    {
                        MessageBox.Show($"Vui lòng nhập trường {col}.");
                        return;
                    }
                }

                string sql = $@"
INSERT INTO GiaoVien 
  (MaGiaoVien, HoTen, NgaySinh, GioiTinh, SoDienThoai, Email, DiaChi)
VALUES
  (N'{row["MaGiaoVien"]}', N'{row["HoTen"]}', '{Convert.ToDateTime(row["NgaySinh"]):yyyy-MM-dd}',
   N'{row["GioiTinh"]}', '{row["SoDienThoai"]}', '{row["Email"]}', N'{row["DiaChi"]}')";

                try
                {
                    kn.ThucThi(sql);
                    MessageBox.Show("Thêm giáo viên thành công.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 giáo viên để xóa.");
                return;
            }

            string ma = dataGridViewDiem.SelectedRows[0].Cells["MaGiaoVien"].Value.ToString();
            if (MessageBox.Show($"Bạn có chắc muốn xóa GV {ma}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            kn.ThucThi($"DELETE FROM GiaoVien WHERE MaGiaoVien = N'{ma}'");
            LoadData();
            MessageBox.Show("Xóa thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (dataGridViewDiem.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Chọn 1 giáo viên để sửa.");
                    return;
                }
                dataGridViewDiem.ReadOnly = false;
                dataGridViewDiem.BeginEdit(true);

                isEditing = true;
                btnSua.Text = "Lưu";
                MessageBox.Show("Chỉnh sửa trực tiếp trên grid, sau đó nhấn 'Lưu'.");
            }
            else
            {
                // lưu sửa
                dataGridViewDiem.EndEdit();
                var row = dataGridViewDiem.SelectedRows[0];

                string ma = row.Cells["MaGiaoVien"].Value.ToString();
                string ten = row.Cells["HoTen"].Value.ToString();
                string ns = Convert.ToDateTime(row.Cells["NgaySinh"].Value).ToString("yyyy-MM-dd");
                string gt = row.Cells["GioiTinh"].Value.ToString();
                string sdt = row.Cells["SoDienThoai"].Value.ToString();
                string em = row.Cells["Email"].Value.ToString();
                string dc = row.Cells["DiaChi"].Value.ToString();

                // kiểm tra nhập đủ
                if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) ||
                    string.IsNullOrWhiteSpace(ns) || string.IsNullOrWhiteSpace(gt) ||
                    string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(em) ||
                    string.IsNullOrWhiteSpace(dc))
                {
                    MessageBox.Show("Vui lòng điền đủ tất cả các trường trước khi lưu.");
                    return;
                }

                string sql = $@"
UPDATE GiaoVien SET
    HoTen       = N'{ten}',
    NgaySinh    = '{ns}',
    GioiTinh    = N'{gt}',
    SoDienThoai = '{sdt}',
    Email       = '{em}',
    DiaChi      = N'{dc}'
WHERE MaGiaoVien = N'{ma}'";

                try
                {
                    kn.ThucThi(sql);
                    MessageBox.Show("Cập nhật thành công.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
            }

        }
    }
}