namespace Quản_Lý_Rượu
{
    partial class fBaocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBaocao));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgvDTmonth = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtgvDTyear = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThoatSP = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXemSP = new System.Windows.Forms.Button();
            this.dtgvSP = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTmonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTyear)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 263);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.dtgvDTmonth);
            this.tabPage1.Controls.Add(this.btnXem);
            this.tabPage1.Controls.Add(this.btnThoat);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.dtgvDTyear);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            // 
            // dtgvDTmonth
            // 
            this.dtgvDTmonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDTmonth.Location = new System.Drawing.Point(359, 6);
            this.dtgvDTmonth.Name = "dtgvDTmonth";
            this.dtgvDTmonth.RowHeadersWidth = 51;
            this.dtgvDTmonth.RowTemplate.Height = 24;
            this.dtgvDTmonth.Size = new System.Drawing.Size(222, 222);
            this.dtgvDTmonth.TabIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.Location = new System.Drawing.Point(9, 182);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(110, 35);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem ";
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(241, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 35);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(125, 182);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 35);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "In báo cáo";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtgvDTyear
            // 
            this.dtgvDTyear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDTyear.Location = new System.Drawing.Point(15, 6);
            this.dtgvDTyear.Name = "dtgvDTyear";
            this.dtgvDTyear.RowHeadersWidth = 51;
            this.dtgvDTyear.RowTemplate.Height = 24;
            this.dtgvDTyear.Size = new System.Drawing.Size(331, 151);
            this.dtgvDTyear.TabIndex = 0;
            this.dtgvDTyear.Click += new System.EventHandler(this.dtgvDTyear_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.btnThoatSP);
            this.tabPage2.Controls.Add(this.btnIn);
            this.tabPage2.Controls.Add(this.btnXemSP);
            this.tabPage2.Controls.Add(this.dtgvSP);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bán chạy";
            // 
            // btnThoatSP
            // 
            this.btnThoatSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatSP.Image")));
            this.btnThoatSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatSP.Location = new System.Drawing.Point(473, 187);
            this.btnThoatSP.Name = "btnThoatSP";
            this.btnThoatSP.Size = new System.Drawing.Size(110, 35);
            this.btnThoatSP.TabIndex = 3;
            this.btnThoatSP.Text = "Thoát";
            this.btnThoatSP.UseVisualStyleBackColor = true;
            this.btnThoatSP.Click += new System.EventHandler(this.btnThoatSP_Click);
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(357, 187);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(110, 35);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXemSP
            // 
            this.btnXemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXemSP.Image")));
            this.btnXemSP.Location = new System.Drawing.Point(241, 187);
            this.btnXemSP.Name = "btnXemSP";
            this.btnXemSP.Size = new System.Drawing.Size(110, 35);
            this.btnXemSP.TabIndex = 1;
            this.btnXemSP.Text = "Xem";
            this.btnXemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemSP.UseVisualStyleBackColor = true;
            this.btnXemSP.Click += new System.EventHandler(this.btnXemSP_Click);
            // 
            // dtgvSP
            // 
            this.dtgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSP.Location = new System.Drawing.Point(7, 16);
            this.dtgvSP.Name = "dtgvSP";
            this.dtgvSP.RowHeadersWidth = 51;
            this.dtgvSP.RowTemplate.Height = 24;
            this.dtgvSP.Size = new System.Drawing.Size(587, 165);
            this.dtgvSP.TabIndex = 0;
            // 
            // fBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 278);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fBaocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBaocao";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTmonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTyear)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvDTmonth;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dtgvDTyear;
        private System.Windows.Forms.Button btnThoatSP;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXemSP;
        private System.Windows.Forms.DataGridView dtgvSP;
    }
}