namespace Nhom6QuanLyDiemTHPT
{
    partial class LogIn
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(110, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(270, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Đăng Nhập";

            // textBoxUsername
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 14F);
            this.textBoxUsername.Location = new System.Drawing.Point(50, 100);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(300, 29);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Text = "Tên đăng nhập";
            this.textBoxUsername.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.TextBox_Leave);

            // textBoxPassword
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 14F);
            this.textBoxPassword.Location = new System.Drawing.Point(50, 150);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(300, 29);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Text = "Mật khẩu";
            this.textBoxPassword.UseSystemPasswordChar = false;
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBox_Leave);

            // buttonLogin
            this.buttonLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(50, 210);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(300, 40);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Đăng Nhập";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.Button_MouseLeave);

            // LogIn Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
            this.Load += new System.EventHandler(this.LogIn_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
