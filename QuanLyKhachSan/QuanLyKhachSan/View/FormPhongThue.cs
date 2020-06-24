using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.View
{
    public partial class FormPhongThue : Form
    {
        public FormPhongThue()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-7MQ60DF\\SQLEXPRESS01;database = QuanLyKhachSan; integrated security = SSPI");
        private void HienThi(string truyvan)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(truyvan, con); // lay du lieu vao da
            DataTable tb = new DataTable();
            da.Fill(tb); // do du lieu vao table
            dtgr.DataSource = tb; // do table len view
            con.Close();
        }
        private void FormPhongThue_Load(object sender, EventArgs e)
        {
            HienThi("select * from PhongThue");
        }

        private void dtgr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_MaPhong.Text = dtgr.CurrentRow.Cells[0].Value.ToString();
            //txt_TenPhong.Text = dtgr.CurrentRow.Cells[1].Value.ToString();
            //txt_Gia.Text = dtgr.CurrentRow.Cells[2].Value.ToString();
            //txt_MaLoaiPhong.Text = dtgr.CurrentRow.Cells[3].Value.ToString();
            //cb_TrangThai.Text = dtgr.CurrentRow.Cells[4].Value.ToString();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = con.CreateCommand(); // Tu nguon cua sql tao 1 command
            cd.CommandText = "insert into PhongThue values('" + txt_MaPhong.Text + "',N'" + txt_TenPhong.Text + "',N'" + txt_Gia.Text + "',N'" + txt_MaLoaiPhong.Text + "',N'" + cb_TrangThai.Text + "' )";
            cd.ExecuteNonQuery();
            cd.ExecuteNonQuery();
            con.Close();
            HienThi("select * from PhongThue");
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = con.CreateCommand(); // Tu nguon cua sql tao 1 command
            cd.CommandText = "update PhongThue set TenPhong= N'" + txt_TenPhong.Text + "', GiaThue= N'" + txt_Gia.Text + "', MaLoaiPhong = N'" + txt_MaLoaiPhong.Text + "', TrangThai =N'" + cb_TrangThai.Text + "' where MaPhong ='" + txt_MaPhong.Text + "'";
            cd.ExecuteNonQuery();
            con.Close();
            HienThi("select * from PhongThue");
        }

        private void Bt_Xoa_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = con.CreateCommand();
            cd.CommandText = "delete from PhongThue where MaPhong = '" + txt_TenPhong.Text + "'";
            cd.ExecuteNonQuery();
            con.Close();
            HienThi("select * from PhongThue");
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string q = string.Format("select * from PhongThue where MaPhong like '%{0}%'", txt_TimKiem.Text);
            HienThi(q);
        }

        private void dtgr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaPhong.Text = dtgr.CurrentRow.Cells[0].Value.ToString();
            txt_TenPhong.Text = dtgr.CurrentRow.Cells[1].Value.ToString();
            txt_Gia.Text = dtgr.CurrentRow.Cells[2].Value.ToString();
            txt_MaLoaiPhong.Text = dtgr.CurrentRow.Cells[3].Value.ToString();
            cb_TrangThai.Text = dtgr.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
