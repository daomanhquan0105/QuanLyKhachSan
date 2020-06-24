using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Model;

namespace QuanLyKhachSan.View
{
    public partial class FormThanhToan : Form
    {
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        private int maHD;
        public static decimal? tongTien;
        public static decimal? tienPhong;
        public static decimal? tienDV;
        public FormThanhToan()
        {
            InitializeComponent();

        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            comboBoxMaHD.DataSource = db.HoaDons.ToList();
            comboBoxMaHD.DisplayMember = "MaHD";
            comboBoxMaHD.ValueMember = "MaHD";
            //MessageBox.Show("Vui long chon ma hoa don can thanh toan!");


        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thanh toan thanh cong!!  " +
                "Ban co muon xem hoa don khong?", "Thông báo", MessageBoxButtons.YesNo)
               == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                FormXacNhanTT xntt = new FormXacNhanTT();
                FormXacNhanTT.MaHD = maHD;
                xntt.ShowDialog();
            }
        }

        private void listViewDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonXemHD_Click(object sender, EventArgs e)
        {
            tongTien = 0;
            tienPhong = 0;
            tienDV = 0;
            listViewDV.Items.Clear();
            maHD = int.Parse(comboBoxMaHD.SelectedValue.ToString());
            HoaDon hd = db.HoaDons.Single(x => x.MaHD == maHD);
            labelTenKHCTT.Text = hd.KhachHang.TenKH;
            labelCMND.Text = hd.KhachHang.CMND;
            labelNgayNhan.Text = hd.NgayBatDau.Value.ToString("dd/MM/yyyy");
            labelNgayTraPhong.Text = hd.NgayTraPhong.Value.ToString("dd/MM/yyyy");

            labelMaPhong.Text = hd.PhongThue.MaPhong.ToString();
            labelLoaiPhong.Text = hd.PhongThue.LoaiPhong.TenLoai;
            labelTenPhong.Text = hd.PhongThue.TenPhong;
            labelGiaPhong.Text = hd.PhongThue.GiaThue.Value.ToString("#,##");

            DateTime ngayBD = DateTime.Parse(hd.NgayBatDau.Value.ToString("dd/MM/yyyy"));
            DateTime ngayTra= DateTime.Parse(hd.NgayTraPhong.Value.ToString("dd/MM/yyyy"));
            TimeSpan soNgay = ngayTra - ngayBD;
            int SoNgayThue = soNgay.Days;
            tienPhong = hd.PhongThue.GiaThue * SoNgayThue;
            List < ChiTietHoaDon> dsdv = db.ChiTietHoaDons.Where(x => x.MaHD == maHD).ToList();

            foreach (ChiTietHoaDon cthd in dsdv)
            {
                ListViewItem lve = new ListViewItem(cthd.DichVu.TenDV);
                lve.SubItems.Add(cthd.DichVu.GiaDV.Value.ToString("#,##"));
                lve.SubItems.Add(cthd.SoLuong.Value.ToString("#"));
                listViewDV.Items.Add(lve);
                tienDV += cthd.DichVu.GiaDV * cthd.SoLuong;
            }
            tongTien = tienDV + tienPhong;
            if (radioButtonHongNhe.Checked)
            {
                tongTien = 300000 + tienPhong + tienDV;
            }
            else if (radioButtonHongNang.Checked)
            {
                tongTien = tongTien + tongTien / 2;
            }
            else
            {
                tongTien = tienPhong + tienDV;
            }
            labelTongTien.Text = tongTien.Value.ToString("#,##");
        }

        public Label tenKH
        {
            get
            {
                return labelTenKHCTT;
            }
        }

       
        public Label CMNDTT
        {
            get
            {
                return labelCMND;
            }
        }

        public Label NgayNhan
        {
            get
            {
                return labelNgayNhan;
            }
        }

        public Label NgayTra
        {
            get
            {
                return labelNgayTraPhong;
            }
        }
        public Label LoaiPhong
        {
            get
            {
                return labelLoaiPhong;
            }
        }
        public Label TenPhong
        {
            get
            {
                return labelTenPhong;
            }
        }
        
        public RadioButton HongNhe
        {
            get
            {
                return radioButtonHongNhe;
            }
        }

        public RadioButton HongNang
        {
            get
            {
                return radioButtonHongNang;
            }
        }

         public RadioButton ConTot
        {
            get
            {
                return radioButtonTot;
            }
        }

    }
}
