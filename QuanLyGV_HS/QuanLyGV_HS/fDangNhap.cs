using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGV_HS;
using QuanLyGV_HS.Data;

namespace QuanLyGV_HS
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }
        private String m_TenNguoiDung;
        public String lay_TenNguoiDung
        {
            get { return m_TenNguoiDung; }
            set { m_TenNguoiDung = value; }
        }
        private String m_MatKhau;
        public String lay_MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            String tenDangnhap = tbUser.Text;
            String matKhau = tbPassword.Text;
            int ketQua = Connect.DangNhap(tenDangnhap, matKhau);
            switch (ketQua)
            {
                case 0:
                    MessageBox.Show("Không tồn tại người dùng trong hệ thống");
                    break;
                case 1:
                    MessageBox.Show("Mật khẩu sai");
                    break;
                case 2:
                    MenuChinh menu = new MenuChinh();
                    this.Hide();
                    menu.Show();
                    break;
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            tbUser.Text = "";
            tbPassword.Text = "";
        }
        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }
