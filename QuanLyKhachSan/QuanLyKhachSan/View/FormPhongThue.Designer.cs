namespace QuanLyKhachSan.View
{
    partial class FormPhongThue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaLoaiPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.dtgr = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TenPhong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_MaLoaiPhong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_TrangThai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Gia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_MaPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 223);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng thuê:";
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Location = new System.Drawing.Point(143, 62);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(188, 22);
            this.txt_TenPhong.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên phòng:";
            // 
            // txt_MaLoaiPhong
            // 
            this.txt_MaLoaiPhong.Location = new System.Drawing.Point(143, 133);
            this.txt_MaLoaiPhong.Name = "txt_MaLoaiPhong";
            this.txt_MaLoaiPhong.Size = new System.Drawing.Size(127, 22);
            this.txt_MaLoaiPhong.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ma Loai phong:";
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Items.AddRange(new object[] {
            "Trống",
            "Đã Thuê"});
            this.cb_TrangThai.Location = new System.Drawing.Point(143, 169);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(117, 24);
            this.cb_TrangThai.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trạng Thái:";
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(143, 93);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(188, 22);
            this.txt_Gia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá thuê:";
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Location = new System.Drawing.Point(143, 25);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(188, 22);
            this.txt_MaPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaPhong:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(619, 216);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(133, 22);
            this.txt_TimKiem.TabIndex = 20;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tìm Mã:";
            // 
            // Bt_Xoa
            // 
            this.Bt_Xoa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Bt_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Xoa.Location = new System.Drawing.Point(290, 213);
            this.Bt_Xoa.Name = "Bt_Xoa";
            this.Bt_Xoa.Size = new System.Drawing.Size(86, 27);
            this.Bt_Xoa.TabIndex = 18;
            this.Bt_Xoa.Text = "Xóa";
            this.Bt_Xoa.UseVisualStyleBackColor = false;
            this.Bt_Xoa.Click += new System.EventHandler(this.Bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.Location = new System.Drawing.Point(147, 213);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(86, 27);
            this.bt_Sua.TabIndex = 17;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(19, 213);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(86, 27);
            this.bt_Them.TabIndex = 15;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // dtgr
            // 
            this.dtgr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgr.Location = new System.Drawing.Point(0, 0);
            this.dtgr.Name = "dtgr";
            this.dtgr.RowHeadersWidth = 51;
            this.dtgr.RowTemplate.Height = 24;
            this.dtgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgr.Size = new System.Drawing.Size(803, 207);
            this.dtgr.TabIndex = 16;
            this.dtgr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgr_CellClick);
            this.dtgr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgr_CellContentClick);
            // 
            // FormPhongThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.dtgr);
            this.Name = "FormPhongThue";
            this.Text = "FormPhongThue";
            this.Load += new System.EventHandler(this.FormPhongThue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaLoaiPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.DataGridView dtgr;
    }
}