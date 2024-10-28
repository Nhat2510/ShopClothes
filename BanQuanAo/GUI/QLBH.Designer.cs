namespace BanQuanAo.GUI
{
    partial class frm_QLBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLBH));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maSP = new System.Windows.Forms.TextBox();
            this.txt_tenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.cb_loaiSP = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_tenHinh = new System.Windows.Forms.TextBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_loadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txt_maSP
            // 
            this.txt_maSP.Location = new System.Drawing.Point(194, 85);
            this.txt_maSP.Name = "txt_maSP";
            this.txt_maSP.Size = new System.Drawing.Size(125, 30);
            this.txt_maSP.TabIndex = 2;
            // 
            // txt_tenSP
            // 
            this.txt_tenSP.Location = new System.Drawing.Point(194, 133);
            this.txt_tenSP.Name = "txt_tenSP";
            this.txt_tenSP.Size = new System.Drawing.Size(203, 30);
            this.txt_tenSP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhập";
            // 
            // dt_ngayNhap
            // 
            this.dt_ngayNhap.Cursor = System.Windows.Forms.Cursors.No;
            this.dt_ngayNhap.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayNhap.Location = new System.Drawing.Point(194, 231);
            this.dt_ngayNhap.Name = "dt_ngayNhap";
            this.dt_ngayNhap.Size = new System.Drawing.Size(200, 30);
            this.dt_ngayNhap.TabIndex = 5;
            // 
            // cb_loaiSP
            // 
            this.cb_loaiSP.FormattingEnabled = true;
            this.cb_loaiSP.Location = new System.Drawing.Point(427, 133);
            this.cb_loaiSP.Name = "cb_loaiSP";
            this.cb_loaiSP.Size = new System.Drawing.Size(202, 33);
            this.cb_loaiSP.TabIndex = 7;
            this.cb_loaiSP.SelectedIndexChanged += new System.EventHandler(this.cb_loaiSP_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(653, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_tenHinh
            // 
            this.txt_tenHinh.Location = new System.Drawing.Point(653, 304);
            this.txt_tenHinh.Name = "txt_tenHinh";
            this.txt_tenHinh.Size = new System.Drawing.Size(164, 30);
            this.txt_tenHinh.TabIndex = 8;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(194, 181);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(203, 30);
            this.txt_Gia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá";
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(194, 279);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(203, 30);
            this.txt_soLuong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 249);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(835, 407);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(118, 44);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(835, 612);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(118, 44);
            this.btn_tim.TabIndex = 11;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(835, 542);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(118, 44);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(835, 475);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(118, 44);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_loadd
            // 
            this.btn_loadd.Location = new System.Drawing.Point(61, 346);
            this.btn_loadd.Name = "btn_loadd";
            this.btn_loadd.Size = new System.Drawing.Size(118, 44);
            this.btn_loadd.TabIndex = 9;
            this.btn_loadd.Text = "Load lại";
            this.btn_loadd.UseVisualStyleBackColor = true;
            this.btn_loadd.Click += new System.EventHandler(this.btn_loadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(307, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 44);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cập nhật sản phẩm";
            // 
            // frm_QLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 703);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_loadd);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenHinh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_loaiSP);
            this.Controls.Add(this.dt_ngayNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenSP);
            this.Controls.Add(this.txt_maSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_QLBH";
            this.Text = "Cập nhật sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QLBH_FormClosing);
            this.Load += new System.EventHandler(this.frm_QLBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_maSP;
        public System.Windows.Forms.TextBox txt_tenSP;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dt_ngayNhap;
        public System.Windows.Forms.ComboBox cb_loaiSP;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_tenHinh;
        public System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_loadd;
        private System.Windows.Forms.Label label6;
    }
}