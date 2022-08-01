using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class fPharmarcy_Manager : Form
    {
        public fPharmarcy_Manager()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fKhach_hang f = new fKhach_hang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLíTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fQuan_Ly_Tai_Khoan f = new fQuan_Ly_Tai_Khoan();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fPharmarcy_Manager_Load(object sender, EventArgs e)
        {

        }

        private void khoLuuTrữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKho_Luu_Tru f = new fKho_Luu_Tru();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThuoc f = new fThuoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void loạiThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLoai_Thuoc f = new fLoai_Thuoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fHoa_Don f = new fHoa_Don ();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void phiếuNhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fPhieu_Nhap_Hang f = new fPhieu_Nhap_Hang ();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fNha_Cung_Cap f = new fNha_Cung_Cap ();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
