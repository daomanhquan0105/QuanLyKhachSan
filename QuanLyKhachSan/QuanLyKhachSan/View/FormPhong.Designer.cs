namespace QuanLyKhachSan.View
{
    partial class FormPhong
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
            this.TenLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.PnTt = new System.Windows.Forms.Panel();
            this.radioButtonDaThue = new System.Windows.Forms.RadioButton();
            this.radioButtonConTrong = new System.Windows.Forms.RadioButton();
            this.MaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ListPhong = new System.Windows.Forms.ListView();
            this.GiaThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LbTenPhong = new System.Windows.Forms.Label();
            this.LbMaPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbGiaThue = new System.Windows.Forms.TextBox();
            this.PnTt.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TenLoai
            // 
            this.TenLoai.Text = "Loại Phòng";
            this.TenLoai.Width = 214;
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "Trạng Thái";
            this.TrangThai.Width = 130;
            // 
            // TenPhong
            // 
            this.TenPhong.Text = "Tên Phòng";
            this.TenPhong.Width = 202;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(249, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 46);
            this.button3.TabIndex = 31;
            this.button3.Text = "Chi Tiết  ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PnTt
            // 
            this.PnTt.Controls.Add(this.radioButtonDaThue);
            this.PnTt.Controls.Add(this.radioButtonConTrong);
            this.PnTt.Location = new System.Drawing.Point(136, 251);
            this.PnTt.Name = "PnTt";
            this.PnTt.Size = new System.Drawing.Size(244, 63);
            this.PnTt.TabIndex = 30;
            // 
            // radioButtonDaThue
            // 
            this.radioButtonDaThue.AutoSize = true;
            this.radioButtonDaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDaThue.Location = new System.Drawing.Point(122, 21);
            this.radioButtonDaThue.Name = "radioButtonDaThue";
            this.radioButtonDaThue.Size = new System.Drawing.Size(98, 24);
            this.radioButtonDaThue.TabIndex = 10;
            this.radioButtonDaThue.TabStop = true;
            this.radioButtonDaThue.Text = "Đã Thuê ";
            this.radioButtonDaThue.UseVisualStyleBackColor = true;
            // 
            // radioButtonConTrong
            // 
            this.radioButtonConTrong.AutoSize = true;
            this.radioButtonConTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonConTrong.Location = new System.Drawing.Point(3, 21);
            this.radioButtonConTrong.Name = "radioButtonConTrong";
            this.radioButtonConTrong.Size = new System.Drawing.Size(113, 24);
            this.radioButtonConTrong.TabIndex = 9;
            this.radioButtonConTrong.TabStop = true;
            this.radioButtonConTrong.Text = "Còn Trống ";
            this.radioButtonConTrong.UseVisualStyleBackColor = true;
            // 
            // MaPhong
            // 
            this.MaPhong.Text = "Mã Phòng";
            this.MaPhong.Width = 132;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.ListPhong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(383, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 589);
            this.panel3.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(24, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "Quay Lại ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListPhong
            // 
            this.ListPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPhong,
            this.TenPhong,
            this.TrangThai,
            this.GiaThue,
            this.TenLoai});
            this.ListPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListPhong.FullRowSelect = true;
            this.ListPhong.GridLines = true;
            this.ListPhong.HideSelection = false;
            this.ListPhong.Location = new System.Drawing.Point(24, 70);
            this.ListPhong.Name = "ListPhong";
            this.ListPhong.Size = new System.Drawing.Size(899, 481);
            this.ListPhong.TabIndex = 2;
            this.ListPhong.UseCompatibleStateImageBehavior = false;
            this.ListPhong.View = System.Windows.Forms.View.Details;
            this.ListPhong.SelectedIndexChanged += new System.EventHandler(this.ListPhong_SelectedIndexChanged);
            // 
            // GiaThue
            // 
            this.GiaThue.Text = "Giá";
            this.GiaThue.Width = 215;
            // 
            // LbTenPhong
            // 
            this.LbTenPhong.AutoSize = true;
            this.LbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenPhong.Location = new System.Drawing.Point(133, 228);
            this.LbTenPhong.Name = "LbTenPhong";
            this.LbTenPhong.Size = new System.Drawing.Size(29, 20);
            this.LbTenPhong.TabIndex = 29;
            this.LbTenPhong.Text = ".....";
            // 
            // LbMaPhong
            // 
            this.LbMaPhong.AutoSize = true;
            this.LbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaPhong.Location = new System.Drawing.Point(133, 181);
            this.LbMaPhong.Name = "LbMaPhong";
            this.LbMaPhong.Size = new System.Drawing.Size(29, 20);
            this.LbMaPhong.TabIndex = 28;
            this.LbMaPhong.Text = ".....";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(136, 381);
            this.cboLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(210, 29);
            this.cboLoaiPhong.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã Phòng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Giá Thuê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Trạng Thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 381);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Phòng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.PnTt);
            this.panel2.Controls.Add(this.LbTenPhong);
            this.panel2.Controls.Add(this.LbMaPhong);
            this.panel2.Controls.Add(this.cboLoaiPhong);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TbGiaThue);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 589);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Danh Sách Phòng";
            // 
            // TbGiaThue
            // 
            this.TbGiaThue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbGiaThue.Location = new System.Drawing.Point(136, 321);
            this.TbGiaThue.Margin = new System.Windows.Forms.Padding(4);
            this.TbGiaThue.Name = "TbGiaThue";
            this.TbGiaThue.Size = new System.Drawing.Size(210, 29);
            this.TbGiaThue.TabIndex = 17;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 589);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.PnTt.ResumeLayout(false);
            this.PnTt.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader TenLoai;
        private System.Windows.Forms.ColumnHeader TrangThai;
        private System.Windows.Forms.ColumnHeader TenPhong;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PnTt;
        private System.Windows.Forms.RadioButton radioButtonDaThue;
        private System.Windows.Forms.RadioButton radioButtonConTrong;
        private System.Windows.Forms.ColumnHeader MaPhong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView ListPhong;
        private System.Windows.Forms.ColumnHeader GiaThue;
        private System.Windows.Forms.Label LbTenPhong;
        private System.Windows.Forms.Label LbMaPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbGiaThue;
    }
}