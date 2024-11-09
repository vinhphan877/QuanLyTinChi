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
    public partial class quanlymonhocForm : Form
    {
        string connectionString = @"Data Source=PHANTHANHVINH;Initial Catalog=dktc;Integrated Security=True";
        public quanlymonhocForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT ma_mon, ten_mon, so_tiet, loai, he FROM MonHoc";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable(); 

                            da.Fill(dt); 

                            dgv_ttmh.DataSource = dt; 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }


        private void quanlymonhocForm_Load(object sender, EventArgs e)
        {
            
        }

        private void bnt_Them_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (string.IsNullOrWhiteSpace(txt_mamon.Text) ||
                        string.IsNullOrWhiteSpace(txt_sotiet.Text) ||
                        string.IsNullOrWhiteSpace(txt_tenmon.Text) ||
                        cmb_loai.SelectedItem == null ||
                        cmb_he.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                        return;
                    }

                    string query = "INSERT INTO MonHoc (ma_mon, ten_mon, so_tiet, loai, he) " +
                                   "VALUES (@MaMon, @TenMon, @SoTiet, @Loai, @He)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMon", txt_mamon.Text);
                        cmd.Parameters.AddWithValue("@TenMon", txt_tenmon.Text);
                        cmd.Parameters.AddWithValue("@SoTiet", int.Parse(txt_sotiet.Text));
                        cmd.Parameters.AddWithValue("@Loai", cmb_loai.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@He", cmb_he.SelectedItem?.ToString());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm môn học thành công!");
                            LoadData(); 

                            txt_mamon.Text = string.Empty;
                            txt_tenmon.Text = string.Empty;
                            txt_sotiet.Text = string.Empty;
                            cmb_loai.SelectedIndex = -1;
                            cmb_he.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm môn học.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
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

                    if (string.IsNullOrWhiteSpace(txt_mamon.Text) ||
                        string.IsNullOrWhiteSpace(txt_tenmon.Text) ||
                        string.IsNullOrWhiteSpace(txt_sotiet.Text) ||
                        cmb_loai.SelectedItem == null ||
                        cmb_he.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                        return;
                    }

                    string query = "UPDATE MonHoc SET ten_mon = @TenMon, so_tiet = @SoTiet, loai = @Loai, he = @He " +
                                   "WHERE ma_mon = @MaMon";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMon", txt_mamon.Text);
                        cmd.Parameters.AddWithValue("@TenMon", txt_tenmon.Text);
                        cmd.Parameters.AddWithValue("@SoTiet", int.Parse(txt_sotiet.Text));
                        cmd.Parameters.AddWithValue("@Loai", cmb_loai.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@He", cmb_he.SelectedItem?.ToString());

                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật môn học thành công!");
                            LoadData(); 

                            txt_mamon.Text = string.Empty;
                            txt_tenmon.Text = string.Empty;
                            txt_sotiet.Text = string.Empty;
                            cmb_loai.SelectedIndex = -1;
                            cmb_he.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật môn học.");
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

                    if (string.IsNullOrWhiteSpace(txt_mamon.Text))
                    {
                        MessageBox.Show("Vui lòng chọn môn học cần xóa.");
                        return;
                    }

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }

                    string query = "DELETE FROM MonHoc WHERE ma_mon = @MaMon";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMon", txt_mamon.Text);

                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa môn học thành công!");
                            LoadData(); 

                            txt_mamon.Text = string.Empty;
                            txt_tenmon.Text = string.Empty;
                            txt_sotiet.Text = string.Empty;
                            cmb_loai.SelectedIndex = -1;
                            cmb_he.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa môn học. Mã môn học không tồn tại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgv_ttmh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ttmh.Rows[e.RowIndex];

                txt_mamon.Text = row.Cells["ma_mon"].Value?.ToString();
                txt_tenmon.Text = row.Cells["ten_mon"].Value?.ToString();
                txt_sotiet.Text = row.Cells["so_tiet"].Value?.ToString();
                cmb_loai.SelectedItem = row.Cells["loai"].Value?.ToString();
                cmb_he.SelectedItem = row.Cells["he"].Value?.ToString();
            }
        }
    }
}
