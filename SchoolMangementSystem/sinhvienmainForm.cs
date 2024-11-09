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
    public partial class sinhvienmainForm : Form
    {
        public sinhvienmainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ThongTinSinhVien_Click(object sender, EventArgs e)
        {
            thongtinSinhVien ttsvForm = new thongtinSinhVien();
            ttsvForm.StartPosition = FormStartPosition.Manual;
            ttsvForm.Location = new Point(442, 132);
            ttsvForm.Show();
        }

        private void QuanLyTinChi_Click(object sender, EventArgs e)
        {
            quanlytinchiForm qltcForm = new quanlytinchiForm();
            qltcForm.StartPosition = FormStartPosition.Manual;
            qltcForm.Location = new Point(442, 132);
            qltcForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn Chắc Chắn Muốn Đăng Xuất?", "Thônhg Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                loginForm lForm = new loginForm();
                lForm.Show();
                this.Hide();
            }
        }
    }
}
