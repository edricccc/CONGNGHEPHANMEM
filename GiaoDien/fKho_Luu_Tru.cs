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
    public partial class fKho_Luu_Tru : Form
    {
        public fKho_Luu_Tru()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSuaKho.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void fKho_Luu_Tru_Load(object sender, EventArgs e)
        {

        }

        private void lblTenKho_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiemKho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
