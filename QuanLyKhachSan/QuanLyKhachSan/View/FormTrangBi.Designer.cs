namespace QuanLyKhachSan.View
{
    partial class FormTrangBi
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.ListTrangBi = new System.Windows.Forms.ListView();
            this.TenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBTenVT = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LbTenPhong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.LbMaPhong = new System.Windows.Forms.Label();
            this.PnTt = new System.Windows.Forms.Panel();
            this.radioButtonKhong = new System.Windows.Forms.RadioButton();
            this.radioButtonCo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.PnTt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên Đồ Dùng :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.ListTrangBi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(339, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 605);
            this.panel3.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(36, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 32);
            this.button5.TabIndex = 42;
            this.button5.Text = "Quay Lại ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ListTrangBi
            // 
            this.ListTrangBi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenPhong,
            this.MaVT,
            this.TenVT,
            this.TinhTrang,
            this.GhiChu});
            this.ListTrangBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTrangBi.FullRowSelect = true;
            this.ListTrangBi.GridLines = true;
            this.ListTrangBi.HideSelection = false;
            this.ListTrangBi.Location = new System.Drawing.Point(36, 56);
            this.ListTrangBi.Name = "ListTrangBi";
            this.ListTrangBi.Size = new System.Drawing.Size(930, 521);
            this.ListTrangBi.TabIndex = 3;
            this.ListTrangBi.UseCompatibleStateImageBehavior = false;
            this.ListTrangBi.View = System.Windows.Forms.View.Details;
            this.ListTrangBi.SelectedIndexChanged += new System.EventHandler(this.ListTrangBi_SelectedIndexChanged);
            // 
            // TenPhong
            // 
            this.TenPhong.Text = "Tên Phòng ";
            this.TenPhong.Width = 155;
            // 
            // MaVT
            // 
            this.MaVT.Text = "Mã Đồ Dùng ";
            this.MaVT.Width = 117;
            // 
            // TenVT
            // 
            this.TenVT.Text = "Tên Đồ Dùng ";
            this.TenVT.Width = 228;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Text = "Tình Trạng";
            this.TinhTrang.Width = 108;
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi Chú ";
            this.GhiChu.Width = 341;
            // 
            // cBTenVT
            // 
            this.cBTenVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTenVT.FormattingEnabled = true;
            this.cBTenVT.Location = new System.Drawing.Point(149, 254);
            this.cBTenVT.Name = "cBTenVT";
            this.cBTenVT.Size = new System.Drawing.Size(172, 28);
            this.cBTenVT.TabIndex = 42;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(149, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 41;
            this.button4.Text = "Sửa ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(246, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 40;
            this.button3.Text = "Xóa ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(48, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 39;
            this.button2.Text = "Thêm ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 38);
            this.label7.TabIndex = 37;
            this.label7.Text = "Đồ Dùng Theo Phòng";
            // 
            // LbTenPhong
            // 
            this.LbTenPhong.AutoSize = true;
            this.LbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenPhong.Location = new System.Drawing.Point(148, 207);
            this.LbTenPhong.Name = "LbTenPhong";
            this.LbTenPhong.Size = new System.Drawing.Size(29, 20);
            this.LbTenPhong.TabIndex = 36;
            this.LbTenPhong.Text = ".....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tên Phòng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mã Phòng :";
            // 
            // tBGhiChu
            // 
            this.tBGhiChu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBGhiChu.Location = new System.Drawing.Point(149, 362);
            this.tBGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.tBGhiChu.Name = "tBGhiChu";
            this.tBGhiChu.Size = new System.Drawing.Size(172, 30);
            this.tBGhiChu.TabIndex = 32;
            // 
            // txtTenTB
            // 
            this.txtTenTB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTB.Location = new System.Drawing.Point(149, 256);
            this.txtTenTB.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(172, 29);
            this.txtTenTB.TabIndex = 13;
            // 
            // LbMaPhong
            // 
            this.LbMaPhong.AutoSize = true;
            this.LbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaPhong.Location = new System.Drawing.Point(148, 162);
            this.LbMaPhong.Name = "LbMaPhong";
            this.LbMaPhong.Size = new System.Drawing.Size(29, 20);
            this.LbMaPhong.TabIndex = 35;
            this.LbMaPhong.Text = ".....";
            // 
            // PnTt
            // 
            this.PnTt.Controls.Add(this.radioButtonKhong);
            this.PnTt.Controls.Add(this.radioButtonCo);
            this.PnTt.Location = new System.Drawing.Point(149, 303);
            this.PnTt.Name = "PnTt";
            this.PnTt.Size = new System.Drawing.Size(175, 35);
            this.PnTt.TabIndex = 31;
            // 
            // radioButtonKhong
            // 
            this.radioButtonKhong.AutoSize = true;
            this.radioButtonKhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKhong.Location = new System.Drawing.Point(95, 8);
            this.radioButtonKhong.Name = "radioButtonKhong";
            this.radioButtonKhong.Size = new System.Drawing.Size(77, 24);
            this.radioButtonKhong.TabIndex = 10;
            this.radioButtonKhong.TabStop = true;
            this.radioButtonKhong.Text = "Không";
            this.radioButtonKhong.UseVisualStyleBackColor = true;
            // 
            // radioButtonCo
            // 
            this.radioButtonCo.AutoSize = true;
            this.radioButtonCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCo.Location = new System.Drawing.Point(3, 8);
            this.radioButtonCo.Name = "radioButtonCo";
            this.radioButtonCo.Size = new System.Drawing.Size(56, 24);
            this.radioButtonCo.TabIndex = 9;
            this.radioButtonCo.TabStop = true;
            this.radioButtonCo.Text = "Có ";
            this.radioButtonCo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ghi Chú  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tình Trạng :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.cBTenVT);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LbTenPhong);
            this.panel1.Controls.Add(this.LbMaPhong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tBGhiChu);
            this.panel1.Controls.Add(this.PnTt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 605);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên Đồ Dùng :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTenTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 605);
            this.panel2.TabIndex = 5;
            // 
            // FormTrangBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormTrangBi";
            this.Text = "FormTrangBi";
            this.Load += new System.EventHandler(this.FormTrangBi_Load);
            this.panel3.ResumeLayout(false);
            this.PnTt.ResumeLayout(false);
            this.PnTt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView ListTrangBi;
        private System.Windows.Forms.ColumnHeader TenPhong;
        private System.Windows.Forms.ColumnHeader MaVT;
        private System.Windows.Forms.ColumnHeader TenVT;
        private System.Windows.Forms.ColumnHeader TinhTrang;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.ComboBox cBTenVT;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbTenPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBGhiChu;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label LbMaPhong;
        private System.Windows.Forms.Panel PnTt;
        private System.Windows.Forms.RadioButton radioButtonKhong;
        private System.Windows.Forms.RadioButton radioButtonCo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}