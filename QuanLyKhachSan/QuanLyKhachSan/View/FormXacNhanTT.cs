using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.View;
using QuanLyKhachSan.Model;

namespace QuanLyKhachSan.View
{
    public partial class FormXacNhanTT : Form
    {
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        
        FormThanhToan ftt = new FormThanhToan();
        public FormXacNhanTT()
        {
            InitializeComponent();
        }
        public static int MaHD;

        private void FormXacNhanTT_Load(object sender, EventArgs e)
        {
            HoaDon hd = db.HoaDons.SingleOrDefault(x => x.MaHD == MaHD);
            labelTenKHTT.Text = hd.KhachHang.TenKH;
            labelCMNDTT.Text = hd.KhachHang.CMND;
            labelNgayNhanTT.Text = hd.NgayBatDau.Value.ToString("dd/MM/yyyy");
            labelNgayTraTT.Text = hd.NgayTraPhong.Value.ToString("dd/MM/yyyy");
            labelLoaiPhongTT.Text = hd.PhongThue.LoaiPhong.TenLoai;
            labelTenPhongTT.Text = hd.PhongThue.TenPhong;
            labelTienPhongTT.Text = FormThanhToan.tienPhong.Value.ToString("#,##");
            labelTienDVTT.Text = FormThanhToan.tienDV.Value.ToString("#,##");
            labelTongTienTT.Text = FormThanhToan.tongTien.Value.ToString("#,##");
            labelPhuThu.Text = (FormThanhToan.tongTien - FormThanhToan.tienDV -FormThanhToan.tienPhong).Value.ToString("#,##"); 
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
