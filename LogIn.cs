using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Nhom6QuanLyDiemTHPT
{
    public partial class LogIn : Form
    {
        private Ketnoi ketnoi = new Ketnoi();

        public LogIn()
        {
            InitializeComponent();
            this.Opacity = 0;
            FadeIn(); // Gọi hiệu ứng khi mở form
        }

        private async void FadeIn()
        {
            for (double i = 0.0; i <= 1.0; i += 0.02)
            {
                this.Opacity = i;
                await System.Threading.Tasks.Task.Delay(5);
            }
            this.Opacity = 1;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.Top = -this.Height;
            Timer slideTimer = new Timer();
            slideTimer.Interval = 1;
            slideTimer.Tick += (s, ev) =>
            {
                if (this.Top < 100)
                {
                    this.Top += 15;
                }
                else
                {
                    slideTimer.Stop();
                }
            };
            slideTimer.Start();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (textBox == textBoxPassword)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                textBox.UseSystemPasswordChar = false;

                textBox.Text = (textBox == textBoxUsername) ? "Tên đăng nhập" : "Mật khẩu";
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.DodgerBlue;
            string user = textBoxUsername.Text.Trim();
            string pass = textBoxPassword.Text;

            // Truy vấn bảng HeThong
            string sql = "SELECT * FROM HeThong WHERE TenDN = @user AND MatKhau = @pass";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@user", user),
                new SqlParameter("@pass", pass)
            };
            DataTable dt = ketnoi.Lay_DuLieuBang(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                string quyen = dt.Rows[0]["Quyen"].ToString();
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (quyen == "GiaoVien")
                {
                    var home = new Home_Teacher();
                    home.Show();
                }
                else if (quyen == "QuanLy")
                {
                    var manager = new TeacherManager();
                    manager.Show();
                }
                else
                {
                    MessageBox.Show("Quyền không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reset password box
                textBoxPassword.Clear();
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
                textBoxPassword.Text = "Mật khẩu";
                textBoxUsername.Focus();
            }
        }
        

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.MediumBlue;
        }

    

    private void Button_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.DeepSkyBlue;
        }
    }
}
