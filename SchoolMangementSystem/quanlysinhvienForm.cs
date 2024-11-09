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

namespace SchoolMangementSystem
{
    public partial class quanlysinhvienForm : Form
    {


        string connectionString = @"Data Source=PHANTHANHVINH;Initial Catalog=dktc;Integrated Security=True";

        private string imagePath = string.Empty;

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SinhVien";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_ttsv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        public quanlysinhvienForm()
        {
            InitializeComponent();
            LoadData();
        }



        private void ThongTinSV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bnt_Them_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (string.IsNullOrWhiteSpace(txt_masv.Text) ||
                        string.IsNullOrWhiteSpace(txt_hoten.Text) ||
                        cmb_gt.SelectedItem == null ||
                        cmb_he.SelectedItem == null ||
                        cmb_khoa.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                        return;
                    }

                    string query = "INSERT INTO SinhVien (ma_sv, ho_ten, gioi_tinh, ngay_sinh, dia_chi, sdt, cccd, he, ma_khoa) " +
                                   "VALUES (@MaSV, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @CCCD, @He, @Khoa)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", txt_masv.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txt_hoten.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", cmb_gt.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@NgaySinh", dtp_ngaysinh.Value);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_diachi.Text);
                        cmd.Parameters.AddWithValue("@SDT", txt_sdt.Text);
                        cmd.Parameters.AddWithValue("@CCCD", txt_cccd.Text);
                        cmd.Parameters.AddWithValue("@He", cmb_he.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Khoa", cmb_khoa.SelectedItem?.ToString());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm sinh viên thành công!");
                            LoadData();

                            txt_masv.Text = string.Empty;
                            txt_sdt.Text = string.Empty;
                            txt_hoten.Text = string.Empty;
                            txt_diachi.Text = string.Empty;
                            txt_cccd.Text = string.Empty;
                            cmb_gt.SelectedIndex = -1;
                            cmb_khoa.SelectedIndex = -1;
                            cmb_he.SelectedIndex = -1;
                            imagePath = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm sinh viên.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh mà bạn mong muốn";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        imagePath = openFileDialog.FileName;

                        Image image = Image.FromFile(imagePath);
                        panel3.BackgroundImage = image;
                        panel3.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi tải ảnh lên: " + ex.Message);
                    }
                }
            }
        }

        private void bnt_Sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (string.IsNullOrWhiteSpace(txt_masv.Text) ||
                        string.IsNullOrWhiteSpace(txt_hoten.Text) ||
                        cmb_gt.SelectedItem == null ||
                        cmb_he.SelectedItem == null ||
                        cmb_khoa.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                        return;
                    }

                    string query = "UPDATE SinhVien " +
                                   "SET ho_ten = @HoTen, gioi_tinh = @GioiTinh, ngay_sinh = @NgaySinh, dia_chi = @DiaChi, " +
                                   "sdt = @SDT, cccd = @CCCD, he = @He, ma_khoa = @Khoa " +
                                   "WHERE ma_sv = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", txt_masv.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txt_hoten.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", cmb_gt.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@NgaySinh", dtp_ngaysinh.Value);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_diachi.Text);
                        cmd.Parameters.AddWithValue("@SDT", txt_sdt.Text);
                        cmd.Parameters.AddWithValue("@CCCD", txt_cccd.Text);
                        cmd.Parameters.AddWithValue("@He", cmb_he.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Khoa", cmb_khoa.SelectedItem?.ToString());

                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật sinh viên thành công!");
                            LoadData(); 

                           
                            txt_masv.Text = string.Empty;
                            txt_sdt.Text = string.Empty;
                            txt_hoten.Text = string.Empty;
                            txt_diachi.Text = string.Empty;
                            txt_cccd.Text = string.Empty;
                            cmb_gt.SelectedIndex = -1;
                            cmb_khoa.SelectedIndex = -1;
                            cmb_he.SelectedIndex = -1;
                            imagePath = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật sinh viên.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void bnt_Xoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (string.IsNullOrWhiteSpace(txt_masv.Text))
                    {
                        MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa.");
                        return;
                    }

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?",
                                                          "Xác nhận xóa",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return; 
                    }

                    string query = "DELETE FROM SinhVien WHERE ma_sv = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", txt_masv.Text);

                        int rowsAffected = cmd.ExecuteNonQuery(); 
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa sinh viên thành công!");
                            LoadData(); 

                            txt_masv.Text = string.Empty;
                            txt_sdt.Text = string.Empty;
                            txt_hoten.Text = string.Empty;
                            txt_diachi.Text = string.Empty;
                            txt_cccd.Text = string.Empty;
                            cmb_gt.SelectedIndex = -1;
                            cmb_khoa.SelectedIndex = -1;
                            cmb_he.SelectedIndex = -1;
                            imagePath = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgv_ttsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ttsv.Rows[e.RowIndex];

                txt_masv.Text = row.Cells["ma_sv"].Value?.ToString();
                txt_hoten.Text = row.Cells["ho_ten"].Value?.ToString();
                cmb_gt.SelectedItem = row.Cells["gioi_tinh"].Value?.ToString();
                dtp_ngaysinh.Value = row.Cells["ngay_sinh"].Value != null
                                     ? Convert.ToDateTime(row.Cells["ngay_sinh"].Value)
                                     : DateTime.Now;
                txt_diachi.Text = row.Cells["dia_chi"].Value?.ToString();
                txt_sdt.Text = row.Cells["sdt"].Value?.ToString();
                txt_cccd.Text = row.Cells["cccd"].Value?.ToString();
                cmb_he.SelectedItem = row.Cells["he"].Value?.ToString();
                cmb_khoa.SelectedItem = row.Cells["ma_khoa"].Value?.ToString();

            }
        }
    }
}
