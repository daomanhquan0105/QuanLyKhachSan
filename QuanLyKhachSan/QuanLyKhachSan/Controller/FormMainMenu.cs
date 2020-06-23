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
    }
}
