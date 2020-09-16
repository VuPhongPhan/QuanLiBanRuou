namespace Quản_Lý_Rượu
{
    partial class fAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccount));
            this.admin = new System.Windows.Forms.TabControl();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtChucvu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenhienthi = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tpNV = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.txtTenHT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReMK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.tpDoiMK = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtReMKnew = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgvMK = new System.Windows.Forms.DataGridView();
            this.dtgvTK = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.admin.SuspendLayout();
            this.tpAdmin.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tpNV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpDoiMK.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.Controls.Add(this.tpAdmin);
            this.admin.Controls.Add(this.tpNV);
            this.admin.Controls.Add(this.tpDoiMK);
            this.admin.Location = new System.Drawing.Point(2, 2);
            this.admin.Name = "admin";
            this.admin.SelectedIndex = 0;
            this.admin.Size = new System.Drawing.Size(650, 276);
            this.admin.TabIndex = 0;
            this.admin.Tag = "";
            // 
            // tpAdmin
            // 
            this.tpAdmin.BackColor = System.Drawing.Color.Silver;
            this.tpAdmin.Controls.Add(this.groupBox4);
            this.tpAdmin.Controls.Add(this.panel1);
            this.tpAdmin.Controls.Add(this.dtgvAccount);
            this.tpAdmin.Location = new System.Drawing.Point(4, 25);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdmin.Size = new System.Drawing.Size(642, 247);
            this.tpAdmin.TabIndex = 0;
            this.tpAdmin.Text = "Tài khoản";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtChucvu);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtTenhienthi);
            this.groupBox4.Controls.Add(this.txtUsername);
            this.groupBox4.Location = new System.Drawing.Point(352, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 158);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin";
            // 
            // txtChucvu
            // 
            this.txtChucvu.FormattingEnabled = true;
            this.txtChucvu.Items.AddRange(new object[] {
            "Quản lí",
            "Nhân viên"});
            this.txtChucvu.Location = new System.Drawing.Point(139, 112);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(129, 24);
            this.txtChucvu.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên hiện thị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtTenhienthi
            // 
            this.txtTenhienthi.Location = new System.Drawing.Point(139, 72);
            this.txtTenhienthi.Name = "txtTenhienthi";
            this.txtTenhienthi.Size = new System.Drawing.Size(129, 22);
            this.txtTenhienthi.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(139, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(129, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(411, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(93, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 48);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(5, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 48);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(6, 13);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(341, 219);
            this.dtgvAccount.TabIndex = 0;
            this.dtgvAccount.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvAccount_CellMouseClick);
            this.dtgvAccount.Click += new System.EventHandler(this.dtgvAccount_Click);
            // 
            // tpNV
            // 
            this.tpNV.BackColor = System.Drawing.Color.Silver;
            this.tpNV.Controls.Add(this.panel2);
            this.tpNV.Controls.Add(this.groupBox2);
            this.tpNV.Controls.Add(this.groupBox1);
            this.tpNV.Location = new System.Drawing.Point(4, 25);
            this.tpNV.Name = "tpNV";
            this.tpNV.Padding = new System.Windows.Forms.Padding(3);
            this.tpNV.Size = new System.Drawing.Size(642, 247);
            this.tpNV.TabIndex = 1;
            this.tpNV.Text = "Thêm người dùng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Location = new System.Drawing.Point(365, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 56);
            this.panel2.TabIndex = 19;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 50);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(102, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 50);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbChucVu);
            this.groupBox2.Controls.Add(this.txtTenHT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(320, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 144);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Quản lí",
            "Nhân viên"});
            this.cbbChucVu.Location = new System.Drawing.Point(152, 94);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(141, 24);
            this.cbbChucVu.TabIndex = 26;
            // 
            // txtTenHT
            // 
            this.txtTenHT.Location = new System.Drawing.Point(152, 44);
            this.txtTenHT.Name = "txtTenHT";
            this.txtTenHT.Size = new System.Drawing.Size(141, 22);
            this.txtTenHT.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên hiện thị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Chức vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenDN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtReMK);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 207);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(165, 46);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(129, 22);
            this.txtTenDN.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nhập lại mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tên đăng nhập";
            // 
            // txtReMK
            // 
            this.txtReMK.Location = new System.Drawing.Point(165, 147);
            this.txtReMK.Name = "txtReMK";
            this.txtReMK.Size = new System.Drawing.Size(129, 22);
            this.txtReMK.TabIndex = 17;
            this.txtReMK.UseSystemPasswordChar = true;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(165, 97);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(129, 22);
            this.txtMK.TabIndex = 18;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // tpDoiMK
            // 
            this.tpDoiMK.BackColor = System.Drawing.Color.Silver;
            this.tpDoiMK.Controls.Add(this.groupBox3);
            this.tpDoiMK.Controls.Add(this.dtgvMK);
            this.tpDoiMK.Controls.Add(this.dtgvTK);
            this.tpDoiMK.Controls.Add(this.button3);
            this.tpDoiMK.Controls.Add(this.button2);
            this.tpDoiMK.Location = new System.Drawing.Point(4, 25);
            this.tpDoiMK.Name = "tpDoiMK";
            this.tpDoiMK.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoiMK.Size = new System.Drawing.Size(642, 247);
            this.tpDoiMK.TabIndex = 2;
            this.tpDoiMK.Text = "Đổi mật khẩu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtReMKnew);
            this.groupBox3.Controls.Add(this.txtMKmoi);
            this.groupBox3.Controls.Add(this.txtMKcu);
            this.groupBox3.Controls.Add(this.txtTenTK);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(26, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 188);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txtReMKnew
            // 
            this.txtReMKnew.Location = new System.Drawing.Point(330, 149);
            this.txtReMKnew.Name = "txtReMKnew";
            this.txtReMKnew.Size = new System.Drawing.Size(159, 22);
            this.txtReMKnew.TabIndex = 6;
            this.txtReMKnew.UseSystemPasswordChar = true;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(330, 107);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(159, 22);
            this.txtMKmoi.TabIndex = 7;
            this.txtMKmoi.UseSystemPasswordChar = true;
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(330, 62);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(159, 22);
            this.txtMKcu.TabIndex = 8;
            this.txtMKcu.UseSystemPasswordChar = true;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(330, 23);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(159, 22);
            this.txtTenTK.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(116, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "nhập lại mật khẩu mới";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nhập mật khẩu mới";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nhập mật khẩu cũ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tên tài khoản";
            // 
            // dtgvMK
            // 
            this.dtgvMK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMK.Location = new System.Drawing.Point(501, 77);
            this.dtgvMK.Name = "dtgvMK";
            this.dtgvMK.RowHeadersWidth = 51;
            this.dtgvMK.RowTemplate.Height = 24;
            this.dtgvMK.Size = new System.Drawing.Size(132, 36);
            this.dtgvMK.TabIndex = 5;
            this.dtgvMK.Visible = false;
            // 
            // dtgvTK
            // 
            this.dtgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTK.Location = new System.Drawing.Point(501, 22);
            this.dtgvTK.Name = "dtgvTK";
            this.dtgvTK.RowHeadersWidth = 51;
            this.dtgvTK.RowTemplate.Height = 24;
            this.dtgvTK.Size = new System.Drawing.Size(132, 36);
            this.dtgvTK.TabIndex = 4;
            this.dtgvTK.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Đồng ý ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(648, 275);
            this.Controls.Add(this.admin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.fAccount_Load);
            this.admin.ResumeLayout(false);
            this.tpAdmin.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tpNV.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpDoiMK.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl admin;
        private System.Windows.Forms.TabPage tpAdmin;
        private System.Windows.Forms.TabPage tpNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TabPage tpDoiMK;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgvTK;
        private System.Windows.Forms.DataGridView dtgvMK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.TextBox txtTenHT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtReMKnew;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox txtChucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenhienthi;
        private System.Windows.Forms.TextBox txtUsername;
    }
}