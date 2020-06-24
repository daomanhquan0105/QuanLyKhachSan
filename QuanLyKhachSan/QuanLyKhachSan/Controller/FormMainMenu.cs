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

namespace QuanLyKhachSan.Controller
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan ftt = new FormThanhToan();
            this.Hide();
            ftt.ShowDialog();
            this.Show();

        }

        private void buttonDichVu_Click(object sender, EventArgs e)
        {
            FormQLDichVu ftt = new FormQLDichVu();
            this.Hide();
            ftt.ShowDialog();
            this.Show();
        }

        private void buttonPhong_Click(object sender, EventArgs e)
        {
            FormPhong phong = new FormPhong();
            this.Hide();
            phong.ShowDialog();
            this.Show();
        }

        private void buttonVatDung_Click(object sender, EventArgs e)
        {
            FormTrangBi vatTu = new FormTrangBi();
            this.Hide();
            vatTu.ShowDialog();
            this.Show();
        }

        private void buttonKhach_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void buttonThuePhong_Click(object sender, EventArgs e)
        {
            
        }

        private void quanLyPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhong phong = new FormPhong();
            this.Hide();
            phong.ShowDialog();
            this.Show();
        }

        private void quanLyVatDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrangBi vatTu = new FormTrangBi();
            this.Hide();
            vatTu.ShowDialog();
            this.Show();
        }

        private void quanLyKhachThueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void quanLyDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDichVu ftt = new FormQLDichVu();
            this.Hide();
            ftt.ShowDialog();
            this.Show();
        }

        private void huongDanSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
