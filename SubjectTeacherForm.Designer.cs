namespace Nhom6QuanLyDiemTHPT
{
    partial class SubjectTeacherForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSuaDiem;
        private System.Windows.Forms.Button btnXoaDiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewDiem;
        private System.Windows.Forms.Panel panelLocTimKiem;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblHocKy;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSuaDiem = new System.Windows.Forms.Button();
            this.btnXoaDiem = new System.Windows.Forms.Button();
            this.dataGridViewDiem = new System.Windows.Forms.DataGridView();
            this.panelLocTimKiem = new System.Windows.Forms.Panel();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaMon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiem)).BeginInit();
            this.panelLocTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackHome
            // 
            this.btnBackHome.BackColor = System.Drawing.Color.White;
            this.btnBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBackHome.Location = new System.Drawing.Point(45, 16);
            this.btnBackHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(180, 62);
            this.btnBackHome.TabIndex = 0;
            this.btnBackHome.Text = "🔙 Quay lại";
            this.btnBackHome.UseVisualStyleBackColor = false;
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Items.AddRange(new object[] {
            "10A1",
            "10A2",
            "11A1",
            "11A2"});
            this.cbLop.Location = new System.Drawing.Point(15, 55);
            this.cbLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(358, 33);
            this.cbLop.TabIndex = 3;
            // 
            // cbHocKy
            // 
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.Items.AddRange(new object[] {
            "Học kỳ 1",
            "Học kỳ 2"});
            this.cbHocKy.Location = new System.Drawing.Point(731, 55);
            this.cbHocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(358, 33);
            this.cbHocKy.TabIndex = 5;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(15, 109);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(538, 31);
            this.txtTimKiem.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(236)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(573, 106);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(177, 41);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSuaDiem
            // 
            this.btnSuaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(236)))));
            this.btnSuaDiem.FlatAppearance.BorderSize = 0;
            this.btnSuaDiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSuaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDiem.ForeColor = System.Drawing.Color.White;
            this.btnSuaDiem.Location = new System.Drawing.Point(765, 106);
            this.btnSuaDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaDiem.Name = "btnSuaDiem";
            this.btnSuaDiem.Size = new System.Drawing.Size(177, 41);
            this.btnSuaDiem.TabIndex = 8;
            this.btnSuaDiem.Text = "✏️ Sửa";
            this.btnSuaDiem.UseVisualStyleBackColor = false;
            // 
            // btnXoaDiem
            // 
            this.btnXoaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(236)))));
            this.btnXoaDiem.FlatAppearance.BorderSize = 0;
            this.btnXoaDiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnXoaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDiem.ForeColor = System.Drawing.Color.White;
            this.btnXoaDiem.Location = new System.Drawing.Point(948, 106);
            this.btnXoaDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaDiem.Name = "btnXoaDiem";
            this.btnXoaDiem.Size = new System.Drawing.Size(177, 41);
            this.btnXoaDiem.TabIndex = 9;
            this.btnXoaDiem.Text = "🗑️ Xóa";
            this.btnXoaDiem.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDiem
            // 
            this.dataGridViewDiem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDiem.ColumnHeadersHeight = 46;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDiem.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDiem.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewDiem.Location = new System.Drawing.Point(45, 297);
            this.dataGridViewDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDiem.Name = "dataGridViewDiem";
            this.dataGridViewDiem.RowHeadersWidth = 82;
            this.dataGridViewDiem.RowTemplate.Height = 28;
            this.dataGridViewDiem.Size = new System.Drawing.Size(1140, 645);
            this.dataGridViewDiem.TabIndex = 2;
            // 
            // panelLocTimKiem
            // 
            this.panelLocTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.panelLocTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLocTimKiem.Controls.Add(this.cboMaMon);
            this.panelLocTimKiem.Controls.Add(this.label1);
            this.panelLocTimKiem.Controls.Add(this.lblLop);
            this.panelLocTimKiem.Controls.Add(this.lblHocKy);
            this.panelLocTimKiem.Controls.Add(this.cbLop);
            this.panelLocTimKiem.Controls.Add(this.cbHocKy);
            this.panelLocTimKiem.Controls.Add(this.txtTimKiem);
            this.panelLocTimKiem.Controls.Add(this.btnTimKiem);
            this.panelLocTimKiem.Controls.Add(this.btnSuaDiem);
            this.panelLocTimKiem.Controls.Add(this.btnXoaDiem);
            this.panelLocTimKiem.Location = new System.Drawing.Point(45, 102);
            this.panelLocTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLocTimKiem.Name = "panelLocTimKiem";
            this.panelLocTimKiem.Size = new System.Drawing.Size(1139, 171);
            this.panelLocTimKiem.TabIndex = 1;
            // 
            // lblLop
            // 
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLop.ForeColor = System.Drawing.Color.White;
            this.lblLop.Location = new System.Drawing.Point(30, 12);
            this.lblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(150, 36);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHocKy.ForeColor = System.Drawing.Color.White;
            this.lblHocKy.Location = new System.Drawing.Point(724, 14);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(150, 36);
            this.lblHocKy.TabIndex = 2;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(395, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã môn";
            // 
            // cboMaMon
            // 
            this.cboMaMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaMon.Items.AddRange(new object[] {
            "Học kỳ 1",
            "Học kỳ 2"});
            this.cboMaMon.Location = new System.Drawing.Point(402, 55);
            this.cboMaMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaMon.Name = "cboMaMon";
            this.cboMaMon.Size = new System.Drawing.Size(292, 33);
            this.cboMaMon.TabIndex = 11;
            // 
            // SubjectTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 989);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.panelLocTimKiem);
            this.Controls.Add(this.dataGridViewDiem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SubjectTeacherForm";
            this.Text = "Quản lý điểm môn học";
            this.Load += new System.EventHandler(this.SubjectTeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiem)).EndInit();
            this.panelLocTimKiem.ResumeLayout(false);
            this.panelLocTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cboMaMon;
        private System.Windows.Forms.Label label1;
    }
}