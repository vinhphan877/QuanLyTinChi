using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMangementSystem
{
    public partial class adminMain : Form
    {
        public adminMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

      

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn Chắc Chắn Muốn Đăng Xuất?", "Thônhg Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                loginForm lForm = new loginForm();
                lForm.Show();
                this.Hide();
                
            }
        }

        

        private void dashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void bnt_QuanLySinhVien_Click(object sender, EventArgs e)
        {
            quanlysinhvienForm qlsvForm = new quanlysinhvienForm();
            qlsvForm.StartPosition = FormStartPosition.Manual;
            qlsvForm.Location = new Point(442,132);
            qlsvForm.Show();
        }

        private void bnt_QuanLyMonHoc_Click(object sender, EventArgs e)
        {
            quanlymonhocForm qlmhForm = new quanlymonhocForm();
            qlmhForm.StartPosition = FormStartPosition.Manual;
            qlmhForm.Location = new Point(442, 132);
            qlmhForm.Show();
        }
    }
}
