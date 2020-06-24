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
using QuanLyKhachSan.View;

namespace QuanLyKhachSan.View
{
    public partial class FormSuDungDV : Form
    {
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public FormSuDungDV()
        {
            InitializeComponent();
        }

        private void FormSuDungDV_Load(object sender, EventArgs e)
        {

            List<ChiTietHoaDon> dsHD = db.ChiTietHoaDons.ToList();
            foreach (ChiTietHoaDon dv in dsHD)
            {
                ListViewItem item = new ListViewItem(dv.MaHD.ToString());
                //item.SubItems.Add(dv.MaDV.ToString());
                item.SubItems.Add(dv.MaDV.ToString());
                item.SubItems.Add(dv.SoLuong.ToString());
                listViewDV.Items.Add(item);
            }
            cbMaHD.DataSource = db.HoaDons.ToList();
            cbMaHD.DisplayMember = "MaHD";
            cbMaHD.ValueMember = "MaHD";

            cbMaDV.DataSource = db.DichVus.ToList();
            cbMaDV.DisplayMember = "MaDV";
            cbMaDV.ValueMember = "MaDV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon gv = new ChiTietHoaDon()
                {
                    // MaDV = txtMaDv.Text,
                    MaHD = int.Parse(cbMaHD.Text),
                    MaDV = int.Parse(cbMaDV.Text),
                    SoLuong = int.Parse(txtSoluong.Text),

                };
                db.ChiTietHoaDons.Add(gv);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                listViewDV.Items.Clear();
                FormSuDungDV_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon gv = db.ChiTietHoaDons.Find(int.Parse(cbMaHD.Text));
                gv.MaDV = int.Parse(cbMaDV.Text);

                gv.SoLuong = int.Parse(txtSoluong.Text);

                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                listViewDV.Items.Clear();
                FormSuDungDV_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon gv = db.ChiTietHoaDons.Find(int.Parse(cbMaHD.Text));
                db.ChiTietHoaDons.Remove(gv);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                listViewDV.Items.Clear();
                FormSuDungDV_Load(sender, e);
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }

        private void listViewDV_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewDV.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listViewDV.SelectedItems[0];
                cbMaHD.Text = itemSelected.SubItems[0].Text;
                cbMaDV.Text = itemSelected.SubItems[1].Text;
                txtSoluong.Text = itemSelected.SubItems[2].Text;

            }
        }
    }
}
