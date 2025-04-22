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
    public partial class ScheduleManager : Form
    {
        Ketnoi ketnoi = new Ketnoi();
        private bool isEditing = false;
        public ScheduleManager()
        {
            InitializeComponent();
        }

        private void ScheduleManager_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }
        private void LoadAllData()
        {
            string sql = "SELECT * FROM PhanCongGiangDay";
            dataGridViewDiem.DataSource = ketnoi.Lay_DuLieuBang(sql);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimThongTin.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadAllData();
                return;
            }

            string sql = @"SELECT * FROM PhanCongGiangDay 
                           WHERE MaGiaoVien = @keyword OR MaMonHoc = @keyword OR MaLop = @keyword OR MaHocKy = @keyword";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@keyword", keyword)
            };

            dataGridViewDiem.DataSource = ketnoi.Lay_DuLieuBang(sql, parameters);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa.");
                return;
            }

            if (!isEditing)
            {
                // Bật chỉnh sửa
                dataGridViewDiem.ReadOnly = false;
                dataGridViewDiem.BeginEdit(true);
                isEditing = true;
                btnSua.Text = "Lưu";
            }
            else
            {
                // Lưu thông tin đã sửa
                try
                {
                    int rowIndex = dataGridViewDiem.SelectedRows[0].Index;

                    string maGV = dataGridViewDiem.Rows[rowIndex].Cells["MaGiaoVien"].Value.ToString();
                    string maMH = dataGridViewDiem.Rows[rowIndex].Cells["MaMonHoc"].Value.ToString();
                    string maLop = dataGridViewDiem.Rows[rowIndex].Cells["MaLop"].Value.ToString();
                    string maHK = dataGridViewDiem.Rows[rowIndex].Cells["MaHocKy"].Value.ToString();

                    string sql = "UPDATE PhanCongGiangDay SET " +
                                 "MaMonHoc = @maMH, MaLop = @maLop, MaHocKy = @maHK " +
                                 "WHERE MaGiaoVien = @maGV";

                    Ketnoi kn = new Ketnoi();
                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@maGV", maGV),
                new SqlParameter("@maMH", maMH),
                new SqlParameter("@maLop", maLop),
                new SqlParameter("@maHK", maHK)
            };

                    kn.KetNoiDuLieu();
                    SqlCommand cmd = new SqlCommand(sql, kn.cnn);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    cmd.ExecuteNonQuery();
                    kn.HuyKetNoi();

                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
                finally
                {
                    dataGridViewDiem.ReadOnly = true;
                    isEditing = false;
                    btnSua.Text = "Sửa";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiem.SelectedRows.Count > 0)
            {
                string maGV = dataGridViewDiem.SelectedRows[0].Cells["MaGiaoVien"].Value.ToString();
                string maMH = dataGridViewDiem.SelectedRows[0].Cells["MaMonHoc"].Value.ToString();
                string maLop = dataGridViewDiem.SelectedRows[0].Cells["MaLop"].Value.ToString();
                string maHK = dataGridViewDiem.SelectedRows[0].Cells["MaHocKy"].Value.ToString();

                string sql = @"DELETE FROM PhanCongGiangDay 
                       WHERE MaGiaoVien = @MaGV AND MaMonHoc = @MaMH AND MaLop = @MaLop AND MaHocKy = @MaHK";

                List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@MaGV", maGV),
            new SqlParameter("@MaMH", maMH),
            new SqlParameter("@MaLop", maLop),
            new SqlParameter("@MaHK", maHK)
        };

                ketnoi.KetNoiDuLieu();
                SqlCommand cmd = new SqlCommand(sql, ketnoi.cnn);
                foreach (var param in parameters)
                    cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                ketnoi.HuyKetNoi();

                MessageBox.Show("Xóa thành công!");
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hàng để xóa!");
            }
        }
    }
}