namespace SchoolMangementSystem
{
    partial class quanlymonhocForm
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
            this.dgv_ttmh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_loai = new System.Windows.Forms.ComboBox();
            this.txt_sotiet = new System.Windows.Forms.TextBox();
            this.txt_tenmon = new System.Windows.Forms.TextBox();
            this.txt_mamon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_he = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bnt_Xoa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bnt_Sua = new System.Windows.Forms.Button();
            this.bnt_Them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttmh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgv_ttmh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 356);
            this.panel1.TabIndex = 1;
            // 
            // dgv_ttmh
            // 
            this.dgv_ttmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttmh.Location = new System.Drawing.Point(27, 58);
            this.dgv_ttmh.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ttmh.Name = "dgv_ttmh";
            this.dgv_ttmh.RowHeadersWidth = 51;
            this.dgv_ttmh.Size = new System.Drawing.Size(1080, 276);
            this.dgv_ttmh.TabIndex = 1;
            this.dgv_ttmh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ttmh_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Môn Học";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cmb_loai);
            this.panel2.Controls.Add(this.txt_sotiet);
            this.panel2.Controls.Add(this.txt_tenmon);
            this.panel2.Controls.Add(this.txt_mamon);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_he);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.bnt_Xoa);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.bnt_Sua);
            this.panel2.Controls.Add(this.bnt_Them);
            this.panel2.Location = new System.Drawing.Point(20, 394);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 281);
            this.panel2.TabIndex = 2;
            // 
            // cmb_loai
            // 
            this.cmb_loai.FormattingEnabled = true;
            this.cmb_loai.Items.AddRange(new object[] {
            "Chuyên Ngành Bắt Buộc",
            "Cơ Sở Ngành",
            "Đại Cương",
            "Chuyên Ngành Tự Chọn"});
            this.cmb_loai.Location = new System.Drawing.Point(699, 39);
            this.cmb_loai.Name = "cmb_loai";
            this.cmb_loai.Size = new System.Drawing.Size(121, 24);
            this.cmb_loai.TabIndex = 27;
            // 
            // txt_sotiet
            // 
            this.txt_sotiet.Location = new System.Drawing.Point(248, 137);
            this.txt_sotiet.Name = "txt_sotiet";
            this.txt_sotiet.Size = new System.Drawing.Size(213, 22);
            this.txt_sotiet.TabIndex = 26;
            // 
            // txt_tenmon
            // 
            this.txt_tenmon.Location = new System.Drawing.Point(248, 80);
            this.txt_tenmon.Name = "txt_tenmon";
            this.txt_tenmon.Size = new System.Drawing.Size(197, 22);
            this.txt_tenmon.TabIndex = 25;
            // 
            // txt_mamon
            // 
            this.txt_mamon.Location = new System.Drawing.Point(248, 41);
            this.txt_mamon.Name = "txt_mamon";
            this.txt_mamon.Size = new System.Drawing.Size(179, 22);
            this.txt_mamon.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số Tiết:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên Môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Môn:";
            // 
            // cmb_he
            // 
            this.cmb_he.FormattingEnabled = true;
            this.cmb_he.Items.AddRange(new object[] {
            "DaiTra",
            "CLC",
            "IP"});
            this.cmb_he.Location = new System.Drawing.Point(699, 129);
            this.cmb_he.Name = "cmb_he";
            this.cmb_he.Size = new System.Drawing.Size(121, 24);
            this.cmb_he.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 132);
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
            // quanlymonhocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quanlymonhocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quanlymonhocForm";
            this.Load += new System.EventHandler(this.quanlymonhocForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttmh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ttmh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_he;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bnt_Xoa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bnt_Sua;
        private System.Windows.Forms.Button bnt_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_loai;
        private System.Windows.Forms.TextBox txt_sotiet;
        private System.Windows.Forms.TextBox txt_tenmon;
        private System.Windows.Forms.TextBox txt_mamon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}