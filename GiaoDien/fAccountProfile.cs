using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data; 

namespace GiaoDien
{
    public partial class fAccountProfile : Form
    {
        public fAccountProfile()
        {
            InitializeComponent();
        }
        // tao ket noi
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-9M7S0SE;Initial Catalog=QLBanThuoc;Integrated Security=True");

        private void fAccountProfile_Load(object sender, EventArgs e)
        {
            connect.Open(); //mo ket noi
            String sql = "select NhanVien.MaNhanVien,NhanVien.TenNhanVien,NhanVien.SDT,NgaySinh,BangCap,GioiTinh";
            SqlCommand cmd = new SqlCommand(sql, connect); // thực hiện câu lênh truy vấn đến sql 
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da= new SqlDataAdapter(cmd);// lưu dữ liệu lấy được vào đây
            DataTable dt = new DataTable(); //khởi tạo một kho dữ liệu ảo 
            //da.Fill(dt); //đổ dữ liệu vào kho 
            dataGridView1.DataSource = dt;  //đổ dữ liệu trong kho vào datagridview
            connect.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPharmarcy_Manager f = new fPharmarcy_Manager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSuaNV.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNhapTenNV_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
