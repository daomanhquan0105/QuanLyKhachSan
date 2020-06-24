namespace QuanLyKhachSan.View
{
    partial class FormQLDichVu
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaDv = new System.Windows.Forms.TextBox();
            this.txtGiaDv = new System.Windows.Forms.TextBox();
            this.txtTenDv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPhieuNhap = new System.Windows.Forms.Label();
            this.listViewDV = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(765, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quản lý sử dụng DV\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(32, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 45);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(328, 14);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(128, 45);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(181, 14);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(128, 45);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMaDv);
            this.panel4.Controls.Add(this.txtGiaDv);
            this.panel4.Controls.Add(this.txtTenDv);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 187);
            this.panel4.TabIndex = 12;
            // 
            // txtMaDv
            // 
            this.txtMaDv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDv.Location = new System.Drawing.Point(179, 24);
            this.txtMaDv.Multiline = true;
            this.txtMaDv.Name = "txtMaDv";
            this.txtMaDv.Size = new System.Drawing.Size(219, 30);
            this.txtMaDv.TabIndex = 9;
            // 
            // txtGiaDv
            // 
            this.txtGiaDv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaDv.Location = new System.Drawing.Point(601, 24);
            this.txtGiaDv.Multiline = true;
            this.txtGiaDv.Name = "txtGiaDv";
            this.txtGiaDv.Size = new System.Drawing.Size(219, 30);
            this.txtGiaDv.TabIndex = 8;
            // 
            // txtTenDv
            // 
            this.txtTenDv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDv.Location = new System.Drawing.Point(178, 92);
            this.txtTenDv.Multiline = true;
            this.txtTenDv.Name = "txtTenDv";
            this.txtTenDv.Size = new System.Drawing.Size(219, 30);
            this.txtTenDv.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá dịch vụ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên dịch vụ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã dịch vụ :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Location = new System.Drawing.Point(0, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 73);
            this.panel3.TabIndex = 11;
            // 
            // lbPhieuNhap
            // 
            this.lbPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPhieuNhap.AutoSize = true;
            this.lbPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuNhap.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbPhieuNhap.Location = new System.Drawing.Point(378, 9);
            this.lbPhieuNhap.Name = "lbPhieuNhap";
            this.lbPhieuNhap.Size = new System.Drawing.Size(285, 37);
            this.lbPhieuNhap.TabIndex = 13;
            this.lbPhieuNhap.Text = "Quản Lý Dịch Vụ ";
            this.lbPhieuNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPhieuNhap.Click += new System.EventHandler(this.lbPhieuNhap_Click);
            // 
            // listViewDV
            // 
            this.listViewDV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDV.FullRowSelect = true;
            this.listViewDV.GridLines = true;
            this.listViewDV.HideSelection = false;
            this.listViewDV.Location = new System.Drawing.Point(6, 63);
            this.listViewDV.Name = "listViewDV";
            this.listViewDV.Size = new System.Drawing.Size(1002, 304);
            this.listViewDV.TabIndex = 14;
            this.listViewDV.UseCompatibleStateImageBehavior = false;
            this.listViewDV.View = System.Windows.Forms.View.Details;
            this.listViewDV.SelectedIndexChanged += new System.EventHandler(this.listViewDV_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Dịch Vụ";
            this.columnHeader3.Width = 236;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên dịch vụ";
            this.columnHeader4.Width = 235;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá dịch vụ";
            this.columnHeader5.Width = 264;
            // 
            // FormQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.Controls.Add(this.listViewDV);
            this.Controls.Add(this.lbPhieuNhap);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "FormQLDichVu";
            this.Text = "FormQLDichVu";
            this.Load += new System.EventHandler(this.FormQLDichVu_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaDv;
        private System.Windows.Forms.TextBox txtGiaDv;
        private System.Windows.Forms.TextBox txtTenDv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPhieuNhap;
        private System.Windows.Forms.ListView listViewDV;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}