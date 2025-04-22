namespace Nhom6QuanLyDiemTHPT
{
    partial class Home_Teacher
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.Label lblGVBM;
        private System.Windows.Forms.PictureBox backgroundImage;

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
            this.components = new System.ComponentModel.Container();

            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.lblGVBM = new System.Windows.Forms.Label();
            this.backgroundImage = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.SuspendLayout();

            // 
            // backgroundImage
            // 
            this.backgroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundImage.Location = new System.Drawing.Point(0, 0);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(800, 450);
            this.backgroundImage.TabStop = false;

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Trang chủ";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#96D6FF");
            this.lblTitle.AutoSize = false;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Size = new System.Drawing.Size(700, 60);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.ColorTranslator.FromHtml("#96D6FF");
            this.panelLeft.Location = new System.Drawing.Point(50, 100);
            this.panelLeft.Size = new System.Drawing.Size(300, 300);
            this.panelLeft.Controls.Add(this.lblGVCN);

            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.ColorTranslator.FromHtml("#96D6FF");
            this.panelRight.Location = new System.Drawing.Point(450, 100);
            this.panelRight.Size = new System.Drawing.Size(300, 300);
            this.panelRight.Controls.Add(this.lblGVBM);

            // 
            // lblGVCN
            // 
            this.lblGVCN.Text = "Giáo viên chủ nhiệm";
            this.lblGVCN.ForeColor = System.Drawing.Color.White;
            this.lblGVCN.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGVCN.BackColor = System.Drawing.Color.Transparent;
            this.lblGVCN.AutoSize = false;
            this.lblGVCN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGVCN.Size = new System.Drawing.Size(280, 280);
            this.lblGVCN.Location = new System.Drawing.Point(10, 10);

            // 
            // lblGVBM
            // 
            this.lblGVBM.Text = "Giáo viên bộ môn";
            this.lblGVBM.ForeColor = System.Drawing.Color.White;
            this.lblGVBM.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGVBM.BackColor = System.Drawing.Color.Transparent;
            this.lblGVBM.AutoSize = false;
            this.lblGVBM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGVBM.Size = new System.Drawing.Size(280, 280);
            this.lblGVBM.Location = new System.Drawing.Point(10, 10);

            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.backgroundImage);
            this.Name = "Home";
            this.Text = "Trang chủ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
