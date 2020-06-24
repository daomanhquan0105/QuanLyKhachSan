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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
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
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            HienThi("select * from KhachHang");
        }

        private void dtgr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKH.Text = dtgr.CurrentRow.Cells[0].Value.ToString();
            txt_HoTen.Text = dtgr.CurrentRow.Cells[1].Value.ToString();
            txt_CMND.Text = dtgr.CurrentRow.Cells[2].Value.ToString();
            txt_QuocTich.Text = dtgr.CurrentRow.Cells[3].Value.ToString();
            cb_GioiTinh.Text = dtgr.CurrentRow.Cells[4].Value.ToString();
            dtime_NgaySinh.Text = dtgr.CurrentRow.Cells[5].Value.ToString();
            txt_SDT.Text = dtgr.CurrentRow.Cells[6].Value.ToString();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = con.CreateCommand(); // Tu nguon cua sql tao 1 command
            cd.CommandText = "insert into KhachHang values('" + txt_MaKH.Text + "',N'" + txt_HoTen.Text + "',N'" + txt_CMND.Text + "',N'" + txt_QuocTich.Text + "',N'" + cb_GioiTinh.Text + "','" + dtime_NgaySinh.Text + "','" + txt_SDT.Text + "' )";
            cd.ExecuteNonQuery();
            con.Close();
            HienThi("select * from KhachHang");
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = con.CreateCommand(); // Tu nguon cua sql tao 1 command
            cd.CommandText = "update KhachHang set TenKH= N'" + txt_HoTen.Text + "', QuocTich = N'" + txt_QuocTich.Text + "', GioiTinh =N'" + cb_GioiTinh.Text + "', NgaySinh = '" + dtime_NgaySinh.Text + "', SoDienThoa = '" + txt_SDT.Text + "' where MaNV ='" + txt_MaKH.Text + "'";
            cd.ExecuteNonQuery();
            con.Close();
            HienThi("select * from KhachHang");
        }

        private void Bt_Xoa_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = con.CreateCommand();
            cd.CommandText = "delete from KhachHang where MaKH = '" + txt_MaKH.Text + "'";
            cd.ExecuteNonQuery();
            con.Close();
            HienThi("select * from KhachHang");
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string q = string.Format("select * from KhachHang where MaKH like '%{0}%'", txt_TimKiem.Text);
            HienThi(q);
        }

        private void dtgr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKH.Text = dtgr.CurrentRow.Cells[0].Value.ToString();
            txt_HoTen.Text = dtgr.CurrentRow.Cells[1].Value.ToString();
            txt_CMND.Text = dtgr.CurrentRow.Cells[2].Value.ToString();
            txt_QuocTich.Text = dtgr.CurrentRow.Cells[3].Value.ToString();
            cb_GioiTinh.Text = dtgr.CurrentRow.Cells[4].Value.ToString();
            dtime_NgaySinh.Text = dtgr.CurrentRow.Cells[5].Value.ToString();
            txt_SDT.Text = dtgr.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
