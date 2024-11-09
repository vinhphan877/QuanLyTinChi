using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMangementSystem
{
    public partial class thongtinSinhVien : Form
    {
        /*
        string connectionString = @"Data Source=PHANTHANHVINH;Initial Catalog=dktc;Integrated Security=True";

        private string studentID;
        private string imagePath;

        public thongtinSinhVien(string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ho_ten, dia_chi, sdt, cccd, gioi_tinh, image FROM SinhVien WHERE ma_sv = @maSV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maSV", studentID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lb_hoten.Text = reader["ho_ten"].ToString();
                        lb_dc.Text = reader["dia_chi"].ToString();
                        lb_sdt.Text = reader["sdt"].ToString();
                        lb_cccd.Text = reader["cccd"].ToString();
                        lb_gt.Text = reader["gioi_tinh"].ToString();

                        if (reader["image"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["image"];
                            using (var ms = new MemoryStream(imageBytes))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }

                        txt_hoten.Text = lb_hoten.Text;
                        txt_diachi.Text = lb_dc.Text;
                        txt_sdt.Text = lb_sdt.Text;
                        txt_cccd.Text = lb_cccd.Text;
                        cmb_gt.SelectedItem = lb_gt.Text;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb_hoten.Text = txt_hoten.Text;
            lb_dc.Text = txt_diachi.Text;
            lb_sdt.Text = txt_sdt.Text;
            lb_cccd.Text = txt_cccd.Text;
            lb_gt.Text = cmb_gt.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE SinhVien SET ho_ten = @hoTen, dia_chi = @diaChi, sdt = @sdt, cccd = @cccd, gioi_tinh = @gioiTinh, image = @image WHERE ma_sv = @maSV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@hoTen", txt_hoten.Text);
                    cmd.Parameters.AddWithValue("@diaChi", txt_diachi.Text);
                    cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text);
                    cmd.Parameters.AddWithValue("@cccd", txt_cccd.Text);
                    cmd.Parameters.AddWithValue("@gioiTinh", cmb_gt.SelectedItem.ToString());

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        byte[] imageBytes = File.ReadAllBytes(imagePath);
                        cmd.Parameters.AddWithValue("@image", imageBytes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@image", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@maSV", studentID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Thông tin đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(imagePath); 
                }
            }
        }*/
    }
}

