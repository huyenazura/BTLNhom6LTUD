namespace Nhom6QuanLyDiemTHPT
{
    partial class StudentManager
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Panel panelGiangVien;
        private System.Windows.Forms.Panel panalHocSinh;
        private System.Windows.Forms.Panel panelPhanCongGD;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.Label lblHocSinh;
        private System.Windows.Forms.Label lblPhanCongGD;
        private System.Windows.Forms.Label lblTongQuan;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.ComboBox cbKyHoc;
        private System.Windows.Forms.TextBox txtTimThongTin;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblKyHoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridViewDiem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelGiangVien = new System.Windows.Forms.Panel();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.panalHocSinh = new System.Windows.Forms.Panel();
            this.lblHocSinh = new System.Windows.Forms.Label();
            this.panelPhanCongGD = new System.Windows.Forms.Panel();
            this.lblPhanCongGD = new System.Windows.Forms.Label();
            this.lblTongQuan = new System.Windows.Forms.Label();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.lblLop = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.lblKyHoc = new System.Windows.Forms.Label();
            this.cbKyHoc = new System.Windows.Forms.ComboBox();
            this.txtTimThongTin = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridViewDiem = new System.Windows.Forms.DataGridView();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.panelGiangVien.SuspendLayout();
            this.panalHocSinh.SuspendLayout();
            this.panelPhanCongGD.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGiangVien
            // 
            this.panelGiangVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.panelGiangVien.Controls.Add(this.lblGiangVien);
            this.panelGiangVien.Location = new System.Drawing.Point(30, 60);
            this.panelGiangVien.Name = "panelGiangVien";
            this.panelGiangVien.Size = new System.Drawing.Size(240, 60);
            this.panelGiangVien.TabIndex = 0;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGiangVien.ForeColor = System.Drawing.Color.White;
            this.lblGiangVien.Location = new System.Drawing.Point(60, 15);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(217, 51);
            this.lblGiangVien.TabIndex = 0;
            this.lblGiangVien.Text = "Giảng Viên";
            // 
            // panalHocSinh
            // 
            this.panalHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(236)))));
            this.panalHocSinh.Controls.Add(this.lblHocSinh);
            this.panalHocSinh.Location = new System.Drawing.Point(280, 60);
            this.panalHocSinh.Name = "panalHocSinh";
            this.panalHocSinh.Size = new System.Drawing.Size(240, 60);
            this.panalHocSinh.TabIndex = 1;
            // 
            // lblHocSinh
            // 
            this.lblHocSinh.AutoSize = true;
            this.lblHocSinh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHocSinh.ForeColor = System.Drawing.Color.White;
            this.lblHocSinh.Location = new System.Drawing.Point(62, 15);
            this.lblHocSinh.Name = "lblHocSinh";
            this.lblHocSinh.Size = new System.Drawing.Size(180, 51);
            this.lblHocSinh.TabIndex = 0;
            this.lblHocSinh.Text = "Học Sinh";
            // 
            // panelPhanCongGD
            // 
            this.panelPhanCongGD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.panelPhanCongGD.Controls.Add(this.lblPhanCongGD);
            this.panelPhanCongGD.Location = new System.Drawing.Point(530, 60);
            this.panelPhanCongGD.Name = "panelPhanCongGD";
            this.panelPhanCongGD.Size = new System.Drawing.Size(240, 60);
            this.panelPhanCongGD.TabIndex = 0;
            // 
            // lblPhanCongGD
            // 
            this.lblPhanCongGD.AutoSize = true;
            this.lblPhanCongGD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPhanCongGD.ForeColor = System.Drawing.Color.White;
            this.lblPhanCongGD.Location = new System.Drawing.Point(13, 15);
            this.lblPhanCongGD.Name = "lblPhanCongGD";
            this.lblPhanCongGD.Size = new System.Drawing.Size(330, 51);
            this.lblPhanCongGD.TabIndex = 0;
            this.lblPhanCongGD.Text = "Phân Công G.Dạy";
            // 
            // lblTongQuan
            // 
            this.lblTongQuan.Location = new System.Drawing.Point(0, 0);
            this.lblTongQuan.Name = "lblTongQuan";
            this.lblTongQuan.Size = new System.Drawing.Size(100, 23);
            this.lblTongQuan.TabIndex = 0;
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.panelTimKiem.Controls.Add(this.lblLop);
            this.panelTimKiem.Controls.Add(this.cbLop);
            this.panelTimKiem.Controls.Add(this.lblNamHoc);
            this.panelTimKiem.Controls.Add(this.cbNamHoc);
            this.panelTimKiem.Controls.Add(this.lblKyHoc);
            this.panelTimKiem.Controls.Add(this.cbKyHoc);
            this.panelTimKiem.Controls.Add(this.txtTimThongTin);
            this.panelTimKiem.Controls.Add(this.btnTimKiem);
            this.panelTimKiem.Controls.Add(this.btnThem);
            this.panelTimKiem.Controls.Add(this.btnSua);
            this.panelTimKiem.Controls.Add(this.btnXoa);
            this.panelTimKiem.Location = new System.Drawing.Point(30, 140);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(740, 100);
            this.panelTimKiem.TabIndex = 2;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLop.ForeColor = System.Drawing.Color.White;
            this.lblLop.Location = new System.Drawing.Point(10, 60);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(68, 37);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp:";
            // 
            // cbLop
            // 
            this.cbLop.Location = new System.Drawing.Point(60, 60);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(80, 33);
            this.cbLop.TabIndex = 1;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNamHoc.ForeColor = System.Drawing.Color.White;
            this.lblNamHoc.Location = new System.Drawing.Point(150, 60);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(80, 37);
            this.lblNamHoc.TabIndex = 0;
            this.lblNamHoc.Text = "Năm:";
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.Location = new System.Drawing.Point(200, 60);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(80, 33);
            this.cbNamHoc.TabIndex = 1;
            // 
            // lblKyHoc
            // 
            this.lblKyHoc.AutoSize = true;
            this.lblKyHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKyHoc.ForeColor = System.Drawing.Color.White;
            this.lblKyHoc.Location = new System.Drawing.Point(290, 60);
            this.lblKyHoc.Name = "lblKyHoc";
            this.lblKyHoc.Size = new System.Drawing.Size(51, 37);
            this.lblKyHoc.TabIndex = 2;
            this.lblKyHoc.Text = "Kỳ:";
            // 
            // cbKyHoc
            // 
            this.cbKyHoc.Location = new System.Drawing.Point(340, 60);
            this.cbKyHoc.Name = "cbKyHoc";
            this.cbKyHoc.Size = new System.Drawing.Size(80, 33);
            this.cbKyHoc.TabIndex = 3;
            // 
            // txtTimThongTin
            // 
            this.txtTimThongTin.Location = new System.Drawing.Point(20, 18);
            this.txtTimThongTin.Name = "txtTimThongTin";
            this.txtTimThongTin.Size = new System.Drawing.Size(477, 31);
            this.txtTimThongTin.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(236)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(510, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(236)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(630, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(236)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(510, 55);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(236)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(630, 55);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDiem
            // 
            this.dataGridViewDiem.AllowUserToAddRows = false;
            this.dataGridViewDiem.AllowUserToDeleteRows = false;
            this.dataGridViewDiem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDiem.ColumnHeadersHeight = 29;
            this.dataGridViewDiem.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewDiem.Location = new System.Drawing.Point(30, 260);
            this.dataGridViewDiem.Name = "dataGridViewDiem";
            this.dataGridViewDiem.ReadOnly = true;
            this.dataGridViewDiem.RowHeadersWidth = 51;
            this.dataGridViewDiem.RowTemplate.Height = 30;
            this.dataGridViewDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDiem.Size = new System.Drawing.Size(740, 350);
            this.dataGridViewDiem.TabIndex = 3;
            // 
            // btnBackHome
            // 
            this.btnBackHome.BackColor = System.Drawing.Color.White;
            this.btnBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBackHome.Location = new System.Drawing.Point(30, 10);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(120, 40);
            this.btnBackHome.TabIndex = 0;
            this.btnBackHome.Text = "🔙 Quay lại";
            this.btnBackHome.UseVisualStyleBackColor = false;
            // 
            // StudentManager
            // 
            this.ClientSize = new System.Drawing.Size(802, 633);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.panelGiangVien);
            this.Controls.Add(this.panalHocSinh);
            this.Controls.Add(this.panelPhanCongGD);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.dataGridViewDiem);
            this.Name = "StudentManager";
            this.Text = "Teacher Dashboard";
            this.Load += new System.EventHandler(this.StudentManager_Load);
            this.panelGiangVien.ResumeLayout(false);
            this.panelGiangVien.PerformLayout();
            this.panalHocSinh.ResumeLayout(false);
            this.panalHocSinh.PerformLayout();
            this.panelPhanCongGD.ResumeLayout(false);
            this.panelPhanCongGD.PerformLayout();
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiem)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
