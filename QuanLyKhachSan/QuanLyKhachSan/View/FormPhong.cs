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
    public partial class FormPhong : Form
    {
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public FormPhong()
        {
            InitializeComponent();
        }

        public class getTTP
        {
            public static int maPhong;
            public static string tenPhong;
        }

        private void ListPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListPhong.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = ListPhong.SelectedItems[0];
                LbMaPhong.Text = itemSelected.SubItems[0].Text;
                LbTenPhong.Text = itemSelected.SubItems[1].Text;
                if (itemSelected.SubItems[2].Text == "True") radioButtonConTrong.Checked = true;
                else radioButtonDaThue.Checked = true;
                TbGiaThue.Text = itemSelected.SubItems[3].Text;
                cboLoaiPhong.Text = itemSelected.SubItems[4].Text;

            }
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            List<PhongThue> dsPhong = db.PhongThues.ToList();
            ListPhong.Items.Clear();
            foreach (PhongThue ph in dsPhong)
            {
                ListViewItem item = new ListViewItem(ph.MaPhong.ToString());
                item.SubItems.Add(ph.TenPhong);
                item.SubItems.Add(ph.TrangThai.ToString());
                item.SubItems.Add(ph.GiaThue.ToString());
                if (ph.MaLoaiPhong == 1)
                {
                    item.SubItems.Add("Phòng Standard");
                }
                else if (ph.MaLoaiPhong == 2)
                {
                    item.SubItems.Add("Phòng Superior");
                }
                else if (ph.MaLoaiPhong == 3)
                {
                    item.SubItems.Add(" Phòng Deluxe ");
                }
                else if (ph.MaLoaiPhong == 4)
                {
                    item.SubItems.Add("Phòng Suite");
                };
                ListPhong.Items.Add(item);
            }
            cboLoaiPhong.DataSource = db.LoaiPhongs.ToList();
            //cboLoaiPhong.DisplayMember = "TenLoai";
            cboLoaiPhong.ValueMember = "TenLoai";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa thông tin phòng này không?", "Thông báo:",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    PhongThue selectedPhong = db.PhongThues.Find(int.Parse(LbMaPhong.Text));
                    selectedPhong.TenPhong = LbTenPhong.Text;
                    selectedPhong.TrangThai = CheckTrangThai();
                    selectedPhong.GiaThue = decimal.Parse(TbGiaThue.Text);
                    if (cboLoaiPhong.Text == "Phòng Standard")
                    {
                        selectedPhong.MaLoaiPhong = 1;
                    }
                    if (cboLoaiPhong.Text == "Phòng Superior")
                    {
                        selectedPhong.MaLoaiPhong = 2;
                    }
                    if (cboLoaiPhong.Text == "Phòng Deluxe")
                    {
                        selectedPhong.MaLoaiPhong = 3;
                    }
                    if (cboLoaiPhong.Text == "Phòng Suite")
                    {
                        selectedPhong.MaLoaiPhong = 4;
                    }

                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    FormPhong_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại. Chi tiết lỗi: " + ex.Message, "thông báo");
            }
        }
        Boolean CheckTrangThai()
        {

            if (radioButtonConTrong.Checked)
            {
                return true;
            }

            else if (radioButtonDaThue.Checked)
            {
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhongThue cttbp = new PhongThue()
            {
                MaPhong = int.Parse(LbMaPhong.Text),
                TenPhong = LbTenPhong.Text,
                //TrangThai=true,
                //GiaThue= 0,
                //MaLoaiPhong=1,

            };
            getTTP.maPhong = cttbp.MaPhong;
            getTTP.tenPhong = cttbp.TenPhong;
            FormTrangBi ftb = new FormTrangBi();
            this.Hide();
            ftb.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
