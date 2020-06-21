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
    public partial class FormDangKy : Form
    {
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDangKyRes_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxTKRes.Text))
                {
                    MessageBox.Show("Ban chua nhap ten tai khoan!!");
                    this.ActiveControl = textBoxTKRes;
                }
                else if (String.IsNullOrEmpty(textBoxMKRes.Text))
                {
                    MessageBox.Show("Ban chua nhap mat khau!!");
                    this.ActiveControl = textBoxMKRes;
                }

                UserTaiKhoan userRes = db.UserTaiKhoans.SingleOrDefault(x => x.TaiKhoan == textBoxTKRes.Text
                && x.MatKhau == textBoxMKRes.Text); // kiem tra tk ton tai
                if(userRes == null)
                {
                    UserTaiKhoan userNew = ThemUser();
                    db.UserTaiKhoans.Add(userNew);
                    db.SaveChanges();
                    MessageBox.Show("Them tai khoan thanh cong!!!");

                    FormDangNhap fdn = new FormDangNhap();
                    this.Hide();
                    fdn.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tai khoan da ton tai!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private UserTaiKhoan ThemUser()
        {
            UserTaiKhoan userNew = new UserTaiKhoan()
            {
                TaiKhoan = textBoxTKRes.Text,
                MatKhau = textBoxMKRes.Text
            };

            return userNew;
        }
    }
}
