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
    public partial class FormTrangBi : Form
    {
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public FormTrangBi()
        {
            InitializeComponent();
        }
        private int MaPhong;
        private int MaDoDung;
        private void FormTrangBi_Load(object sender, EventArgs e)
        {
            int maPhong = FormPhong.getTTP.maPhong;
            string tenPhong = FormPhong.getTTP.tenPhong;
            List<ChiTietDoDungPhong> dsTrangBi = db.ChiTietDoDungPhongs.Where(x => x.MaPhong == maPhong).ToList();
            ListTrangBi.Items.Clear();
            LbMaPhong.Text = maPhong.ToString();
            LbTenPhong.Text = tenPhong;
            foreach (ChiTietDoDungPhong cttb in dsTrangBi)
            {
                ListViewItem item = new ListViewItem(cttb.PhongThue.TenPhong);
                //item.SubItems.Add(cttb.PhongThue.TenPhong);
                item.SubItems.Add(cttb.MaVatTu.ToString());
                item.SubItems.Add(cttb.VatTu.TenVT.ToString());
                item.SubItems.Add(cttb.TinhTrang.ToString());
                item.SubItems.Add(cttb.GhiChu);
                ListTrangBi.Items.Add(item);
            }
            cBTenVT.DataSource = db.VatTus.ToList();
            cBTenVT.DisplayMember = "TenVT";
            cBTenVT.ValueMember = "MaVatTu";
        }

        private void ListTrangBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListTrangBi.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = ListTrangBi.SelectedItems[0];
                MaDoDung = int.Parse(itemSelected.SubItems[1].Text.ToString());
                LbTenPhong.Text = itemSelected.SubItems[0].Text;
                cBTenVT.SelectedValue = int.Parse(itemSelected.SubItems[1].Text);
                if (itemSelected.SubItems[3].Text == "True") radioButtonCo.Checked = true;
                else radioButtonKhong.Checked = true;
                tBGhiChu.Text = itemSelected.SubItems[4].Text;
                //cboLoaiPhong.Text = itemSelected.SubItems[4].Text;

            }
            MaPhong = int.Parse(LbMaPhong.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietDoDungPhong eq = new ChiTietDoDungPhong()
                {
                    MaPhong = int.Parse(LbMaPhong.Text),
                    MaVatTu = int.Parse(cBTenVT.SelectedValue.ToString()),
                    TinhTrang = true,
                    GhiChu = tBGhiChu.Text,
                };
                db.ChiTietDoDungPhongs.Add(eq);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                FormTrangBi_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietDoDungPhong eq = db.ChiTietDoDungPhongs.Single(x => x.MaVatTu == MaDoDung && x.MaPhong == MaPhong);
                //ChiTietDoDungPhong eq = db.ChiTietDoDungPhongs.Find(int.Parse(LbMaPhong.ToString()));
                eq.MaVatTu = int.Parse(cBTenVT.SelectedValue.ToString());
                eq.TinhTrang = CheckTrangThai();
                eq.GhiChu = tBGhiChu.Text;
                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                FormTrangBi_Load(sender, e);
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietDoDungPhong eq = db.ChiTietDoDungPhongs.Single(x => x.MaVatTu == MaDoDung && x.MaPhong == MaPhong);
                db.ChiTietDoDungPhongs.Remove(eq);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                FormTrangBi_Load(sender, e);
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }
        Boolean CheckTrangThai()
        {

            if (radioButtonCo.Checked)
            {
                return true;
            }

            else if (radioButtonKhong.Checked)
            {
                return false;
            }
            return true;
        }
    }
}
