using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGV_HS
{
    public partial class MenuChinh : Form
    {
        public MenuChinh()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fDangNhap dangnhap = new fDangNhap();
            dangnhap.Show();
        }

        private void đánhGiáChấtLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuChinh_Load(object sender, EventArgs e)
        {

        }
    }
}
