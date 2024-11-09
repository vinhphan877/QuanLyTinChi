
namespace SchoolMangementSystem
{
    partial class quanlysinhvienForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_ttsv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_he = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bnt_Xoa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bnt_Sua = new System.Windows.Forms.Button();
            this.bnt_Them = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_khoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_gt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttsv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgv_ttsv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 356);
            this.panel1.TabIndex = 0;
            // 
            // dgv_ttsv
            // 
            this.dgv_ttsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttsv.Location = new System.Drawing.Point(27, 58);
            this.dgv_ttsv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ttsv.Name = "dgv_ttsv";
            this.dgv_ttsv.RowHeadersWidth = 51;
            this.dgv_ttsv.Size = new System.Drawing.Size(1080, 276);
            this.dgv_ttsv.TabIndex = 1;
            this.dgv_ttsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ttsv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dtp_ngaysinh);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_sdt);
            this.panel2.Controls.Add(this.txt_cccd);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmb_he);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.bnt_Xoa);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.bnt_Sua);
            this.panel2.Controls.Add(this.bnt_Them);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cmb_khoa);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_diachi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmb_gt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_hoten);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_masv);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 393);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 281);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(663, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ngày Sinh:";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(742, 135);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(230, 22);
            this.dtp_ngaysinh.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "SĐT:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(416, 101);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(191, 22);
            this.txt_sdt.TabIndex = 22;
            // 
            // txt_cccd
            // 
            this.txt_cccd.Location = new System.Drawing.Point(416, 137);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(178, 22);
            this.txt_cccd.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "CCCD:";
            // 
            // cmb_he
            // 
            this.cmb_he.FormattingEnabled = true;
            this.cmb_he.Items.AddRange(new object[] {
            "Đại Trà",
            "Chất Lượng Cao",
            "Cao Đẳng",
            "Đặc Thù",
            "Quốc Tế"});
            this.cmb_he.Location = new System.Drawing.Point(763, 30);
            this.cmb_he.Name = "cmb_he";
            this.cmb_he.Size = new System.Drawing.Size(121, 24);
            this.cmb_he.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hệ:";
            // 
            // bnt_Xoa
            // 
            this.bnt_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.bnt_Xoa.FlatAppearance.BorderSize = 0;
            this.bnt_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bnt_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bnt_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Xoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Xoa.ForeColor = System.Drawing.Color.White;
            this.bnt_Xoa.Location = new System.Drawing.Point(767, 214);
            this.bnt_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_Xoa.Name = "bnt_Xoa";
            this.bnt_Xoa.Size = new System.Drawing.Size(136, 43);
            this.bnt_Xoa.TabIndex = 17;
            this.bnt_Xoa.Text = "Xóa";
            this.bnt_Xoa.UseVisualStyleBackColor = false;
            this.bnt_Xoa.Click += new System.EventHandler(this.bnt_Xoa_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(599, 214);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 43);
            this.button5.TabIndex = 16;
            this.button5.Text = "Làm Mới";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // bnt_Sua
            // 
            this.bnt_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.bnt_Sua.FlatAppearance.BorderSize = 0;
            this.bnt_Sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bnt_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bnt_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Sua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Sua.ForeColor = System.Drawing.Color.White;
            this.bnt_Sua.Location = new System.Drawing.Point(416, 214);
            this.bnt_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_Sua.Name = "bnt_Sua";
            this.bnt_Sua.Size = new System.Drawing.Size(136, 43);
            this.bnt_Sua.TabIndex = 15;
            this.bnt_Sua.Text = "Sửa";
            this.bnt_Sua.UseVisualStyleBackColor = false;
            this.bnt_Sua.Click += new System.EventHandler(this.bnt_Sua_Click);
            // 
            // bnt_Them
            // 
            this.bnt_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.bnt_Them.FlatAppearance.BorderSize = 0;
            this.bnt_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bnt_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bnt_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Them.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Them.ForeColor = System.Drawing.Color.White;
            this.bnt_Them.Location = new System.Drawing.Point(248, 214);
            this.bnt_Them.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_Them.Name = "bnt_Them";
            this.bnt_Them.Size = new System.Drawing.Size(136, 43);
            this.bnt_Them.TabIndex = 14;
            this.bnt_Them.Text = "Thêm ";
            this.bnt_Them.UseVisualStyleBackColor = false;
            this.bnt_Them.Click += new System.EventHandler(this.bnt_Them_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1000, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(1000, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 106);
            this.panel3.TabIndex = 12;
            // 
            // cmb_khoa
            // 
            this.cmb_khoa.FormattingEnabled = true;
            this.cmb_khoa.Items.AddRange(new object[] {
            "CNTT01"});
            this.cmb_khoa.Location = new System.Drawing.Point(742, 82);
            this.cmb_khoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_khoa.Name = "cmb_khoa";
            this.cmb_khoa.Size = new System.Drawing.Size(191, 24);
            this.cmb_khoa.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Khoa:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(416, 26);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(191, 52);
            this.txt_diachi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa Chỉ:";
            // 
            // cmb_gt
            // 
            this.cmb_gt.FormattingEnabled = true;
            this.cmb_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmb_gt.Location = new System.Drawing.Point(108, 128);
            this.cmb_gt.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_gt.Name = "cmb_gt";
            this.cmb_gt.Size = new System.Drawing.Size(191, 24);
            this.cmb_gt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính:";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(107, 76);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hoten.Multiline = true;
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(191, 30);
            this.txt_hoten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(107, 26);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_masv.Multiline = true;
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(135, 30);
            this.txt_masv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // quanlysinhvienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "quanlysinhvienForm";
            this.Text = "AddStudentsForm";
            this.Load += new System.EventHandler(this.ThongTinSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttsv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ttsv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.ComboBox cmb_gt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_khoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bnt_Them;
        private System.Windows.Forms.Button bnt_Xoa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bnt_Sua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_he;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
    }
}