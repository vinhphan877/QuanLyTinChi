using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SchoolMangementSystem
{
    public partial class loginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=PHANTHANHVINH;Initial Catalog=dktc;Integrated Security=True");
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text) || role.SelectedIndex == -1)
            {
                MessageBox.Show("Vui Lòng Điền Vào Chỗ Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT role FROM login WHERE username=@username AND password=@password AND role=@role";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username.Text.Trim();
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password.Text.Trim();
                        cmd.Parameters.Add("@role", SqlDbType.NVarChar).Value = role.SelectedItem.ToString();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Bạn Đã Đăng Nhập Với Tư Cách: " + table.Rows[0]["role"].ToString(),
                                            "Đăng Nhập Thành Công",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            if (role.SelectedItem.ToString() == "ADMIN")
                            {
                                adminMain aForm = new adminMain();
                                aForm.Show();
                                this.Hide();
                            }
                            else if (role.SelectedItem.ToString() == "sinhvien")
                            {
                                sinhvienmainForm svForm = new sinhvienmainForm();
                                svForm.Show();
                                this.Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Sai Dữ Liệu Nhập Vào", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Kết Nối Với Database: " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }


        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}
