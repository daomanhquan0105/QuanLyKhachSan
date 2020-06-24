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
    public partial class FormQLDichVu : Form
    {
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public FormQLDichVu()
        {
            InitializeComponent();
        }

        private void lbPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void FormQLDichVu_Load(object sender, EventArgs e)
        {
            List<DichVu> dsDV = db.DichVus.ToList();
            foreach (DichVu dv in dsDV)
            {
                ListViewItem item = new ListViewItem(dv.MaDV.ToString());
                //item.SubItems.Add(dv.MaDV.ToString());
                item.SubItems.Add(dv.TenDV.ToString());
                item.SubItems.Add(dv.GiaDV.ToString());
                listViewDV.Items.Add(item);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu gv = new DichVu()
                {
                    // MaDV = txtMaDv.Text,
                    TenDV = txtTenDv.Text,

                    GiaDV = int.Parse(txtGiaDv.Text),

                };
                db.DichVus.Add(gv);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                listViewDV.Items.Clear();
                FormQLDichVu_Load(sender, e);

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
                DichVu gv = db.DichVus.Find(int.Parse(txtMaDv.Text));
                gv.TenDV = txtTenDv.Text;

                gv.GiaDV = int.Parse(txtGiaDv.Text);

                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                listViewDV.Items.Clear();
                FormQLDichVu_Load(sender, e);
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
                DichVu gv = db.DichVus.Find(int.Parse(txtMaDv.Text));
                db.DichVus.Remove(gv);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                listViewDV.Items.Clear();
                FormQLDichVu_Load(sender, e);
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }

        private void listViewDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDV.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listViewDV.SelectedItems[0];
                txtMaDv.Text = itemSelected.SubItems[0].Text;
                txtTenDv.Text = itemSelected.SubItems[1].Text;
                txtGiaDv.Text = itemSelected.SubItems[2].Text;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSuDungDV ftt = new FormSuDungDV();
            this.Hide();
            ftt.ShowDialog();
            this.Show();
        }
    }
}
