namespace QuanLyKhachSan.Controller
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyKhachThueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyDichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongDanSuDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.buttonThuePhong = new System.Windows.Forms.Button();
            this.buttonDichVu = new System.Windows.Forms.Button();
            this.buttonKhach = new System.Windows.Forms.Button();
            this.buttonPhong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(308, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUAN LY KHACH SAN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(865, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyPhongToolStripMenuItem,
            this.quanLyKhachThueToolStripMenuItem,
            this.quanLyDichVuToolStripMenuItem,
            this.thanhToanToolStripMenuItem,
            this.huongDanSuDungToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // quanLyPhongToolStripMenuItem
            // 
            this.quanLyPhongToolStripMenuItem.Name = "quanLyPhongToolStripMenuItem";
            this.quanLyPhongToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.quanLyPhongToolStripMenuItem.Text = "Quan ly phong";
            this.quanLyPhongToolStripMenuItem.Click += new System.EventHandler(this.quanLyPhongToolStripMenuItem_Click);
            // 
            // quanLyKhachThueToolStripMenuItem
            // 
            this.quanLyKhachThueToolStripMenuItem.Name = "quanLyKhachThueToolStripMenuItem";
            this.quanLyKhachThueToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.quanLyKhachThueToolStripMenuItem.Text = "Quan ly khach thue";
            this.quanLyKhachThueToolStripMenuItem.Click += new System.EventHandler(this.quanLyKhachThueToolStripMenuItem_Click);
            // 
            // quanLyDichVuToolStripMenuItem
            // 
            this.quanLyDichVuToolStripMenuItem.Name = "quanLyDichVuToolStripMenuItem";
            this.quanLyDichVuToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.quanLyDichVuToolStripMenuItem.Text = "Quan ly dich vu";
            this.quanLyDichVuToolStripMenuItem.Click += new System.EventHandler(this.quanLyDichVuToolStripMenuItem_Click);
            // 
            // thanhToanToolStripMenuItem
            // 
            this.thanhToanToolStripMenuItem.Name = "thanhToanToolStripMenuItem";
            this.thanhToanToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.thanhToanToolStripMenuItem.Text = "Hóa đơn";
            this.thanhToanToolStripMenuItem.Click += new System.EventHandler(this.thanhToanToolStripMenuItem_Click);
            // 
            // huongDanSuDungToolStripMenuItem
            // 
            this.huongDanSuDungToolStripMenuItem.Name = "huongDanSuDungToolStripMenuItem";
            this.huongDanSuDungToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.huongDanSuDungToolStripMenuItem.Text = "Huong dan su dung";
            this.huongDanSuDungToolStripMenuItem.Click += new System.EventHandler(this.huongDanSuDungToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoatToolStripMenuItem.Text = "Thoat";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(287, 107);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(582, 438);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.buttonThanhToan);
            this.panel6.Controls.Add(this.buttonThuePhong);
            this.panel6.Controls.Add(this.buttonDichVu);
            this.panel6.Controls.Add(this.buttonKhach);
            this.panel6.Controls.Add(this.buttonPhong);
            this.panel6.Location = new System.Drawing.Point(3, 107);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(286, 443);
            this.panel6.TabIndex = 2;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhToan.ForeColor = System.Drawing.Color.White;
            this.buttonThanhToan.Location = new System.Drawing.Point(53, 326);
            this.buttonThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(163, 39);
            this.buttonThanhToan.TabIndex = 5;
            this.buttonThanhToan.Text = "Thanh Toan";
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // buttonThuePhong
            // 
            this.buttonThuePhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonThuePhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThuePhong.ForeColor = System.Drawing.Color.White;
            this.buttonThuePhong.Location = new System.Drawing.Point(53, 194);
            this.buttonThuePhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThuePhong.Name = "buttonThuePhong";
            this.buttonThuePhong.Size = new System.Drawing.Size(163, 39);
            this.buttonThuePhong.TabIndex = 3;
            this.buttonThuePhong.Text = "Thue Phong";
            this.buttonThuePhong.UseVisualStyleBackColor = false;
            this.buttonThuePhong.Click += new System.EventHandler(this.buttonThuePhong_Click);
            // 
            // buttonDichVu
            // 
            this.buttonDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDichVu.ForeColor = System.Drawing.Color.White;
            this.buttonDichVu.Location = new System.Drawing.Point(53, 259);
            this.buttonDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDichVu.Name = "buttonDichVu";
            this.buttonDichVu.Size = new System.Drawing.Size(163, 39);
            this.buttonDichVu.TabIndex = 4;
            this.buttonDichVu.Text = "Dich Vu";
            this.buttonDichVu.UseVisualStyleBackColor = false;
            this.buttonDichVu.Click += new System.EventHandler(this.buttonDichVu_Click);
            // 
            // buttonKhach
            // 
            this.buttonKhach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhach.ForeColor = System.Drawing.Color.White;
            this.buttonKhach.Location = new System.Drawing.Point(53, 127);
            this.buttonKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKhach.Name = "buttonKhach";
            this.buttonKhach.Size = new System.Drawing.Size(163, 39);
            this.buttonKhach.TabIndex = 2;
            this.buttonKhach.Text = "Khach";
            this.buttonKhach.UseVisualStyleBackColor = false;
            this.buttonKhach.Click += new System.EventHandler(this.buttonKhach_Click);
            // 
            // buttonPhong
            // 
            this.buttonPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhong.ForeColor = System.Drawing.Color.White;
            this.buttonPhong.Location = new System.Drawing.Point(53, 61);
            this.buttonPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPhong.Name = "buttonPhong";
            this.buttonPhong.Size = new System.Drawing.Size(163, 39);
            this.buttonPhong.TabIndex = 0;
            this.buttonPhong.Text = "Phong";
            this.buttonPhong.UseVisualStyleBackColor = false;
            this.buttonPhong.Click += new System.EventHandler(this.buttonPhong_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 548);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.Button buttonThuePhong;
        private System.Windows.Forms.Button buttonDichVu;
        private System.Windows.Forms.Button buttonKhach;
        private System.Windows.Forms.Button buttonPhong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhachThueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyDichVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanSuDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyPhongToolStripMenuItem;
    }
}