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
    public partial class EditScore : Form
    {
        Ketnoi kn = new Ketnoi();
        public EditScore()
        {
            InitializeComponent();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelNhapDuLieu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditScore_Load(object sender, EventArgs e)
        {
            BangDiem();
            HienThiBangDiem();


        }
        public void BangDiem()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("select * from BangDiem");
            dataGridViewDiem.DataSource = dta;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaBangDiem.Text = "";
            txtMaMonHoc.Text = "";
            txtMaHocKy.Text = "";
            txtMaHocSinh.Text = "";
            txtDiemMieng_So.Text = "";
            txtDiemGiuaKy_So.Text = "";
            txtDiemCuoiKy_So.Text = "";
            txtDiem15P_So.Text = "";

        }
        public void HienThiBangDiem()
        {
            txtMaBangDiem.DataBindings.Clear();
            txtMaBangDiem.DataBindings.Add("Text", dataGridViewDiem.DataSource, "MaBangDiem");

            txtMaMonHoc.DataBindings.Clear();
            txtMaMonHoc.DataBindings.Add("Text", dataGridViewDiem.DataSource, "MaMonHoc");

            txtMaHocKy.DataBindings.Clear();
            txtMaHocKy.DataBindings.Add("Text", dataGridViewDiem.DataSource, "MaHocKy");

            txtMaHocSinh.DataBindings.Clear();
            txtMaHocSinh.DataBindings.Add("Text", dataGridViewDiem.DataSource, "MaHocSinh");

            txtDiemMieng_So.DataBindings.Clear();
            txtDiemMieng_So.DataBindings.Add("Text", dataGridViewDiem.DataSource, "DiemMieng_So");

                 
            txtDiemGiuaKy_So.DataBindings.Clear();
            txtDiemGiuaKy_So.DataBindings.Add("Text", dataGridViewDiem.DataSource, "DiemGiuaKy_So");

           txtDiemCuoiKy_So.DataBindings.Clear();
            txtDiemCuoiKy_So.DataBindings.Add("Text", dataGridViewDiem.DataSource, "DiemCuoiKy_So");

          
            txtDiem15P_So.DataBindings.Clear();
            txtDiem15P_So.DataBindings.Add("Text", dataGridViewDiem.DataSource, "Diem15P_So");

           
        }
     

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update BangDiem Set DiemMieng_So ='" + txtDiemMieng_So.Text + "',Diem15P_So  = '" + txtDiem15P_So.Text + "'," +
         " DiemGiuaKy_So  ='" + txtDiemGiuaKy_So.Text + "'," +
         " DiemCuoiKy_So = '" + txtDiemCuoiKy_So.Text + "'  where MaBangDiem = '" + txtMaBangDiem.Text + "'";
            kn.ThucThi(sql_Sua);
            BangDiem();
            HienThiBangDiem();
        }

        
    }
}
