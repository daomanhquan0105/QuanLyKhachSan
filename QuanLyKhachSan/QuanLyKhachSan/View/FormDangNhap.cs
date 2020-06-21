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
using QuanLyKhachSan.Controller;

namespace QuanLyKhachSan.View
{
    public partial class FormDangNhap : Form
    {
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public FormDangNhap()
        {
            InitializeComponent();
            textBoxMK.PasswordChar = '*';
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy dk = new FormDangKy();
            this.Hide();
            dk.ShowDialog();

        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            FormMainMenu fm = new FormMainMenu();
            try
            {
                if (String.IsNullOrEmpty(textBoxTK.Text))
                {
                    MessageBox.Show("Ban chua nhap ten tai khoan!!");
                    this.ActiveControl = textBoxTK;
                }
                else if (String.IsNullOrEmpty(textBoxMK.Text))
                {
                    MessageBox.Show("Ban chua nhap mat khau!!");
                    this.ActiveControl = textBoxMK;
                }
                UserTaiKhoan user = db.UserTaiKhoans.SingleOrDefault(x => x.TaiKhoan == textBoxTK.Text
                 && x.MatKhau == textBoxTK.Text);
                if (user != null)
                {
                    this.Hide();
                    fm.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
    }
}
