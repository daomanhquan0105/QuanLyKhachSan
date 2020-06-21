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

namespace QuanLyKhachSan.View
{
    public partial class FormDangNhap : Form
    {
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
            this.Show();

        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
