using BUS.BUS;
using DTO;
using GUI.ChucNangHome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Admin : Form
    {
        Ban_BUS Ban = new Ban_BUS();
        public Admin()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            UCqlTaiKhoan taiKhoan = new UCqlTaiKhoan();
            Panel.Controls.Clear();
            Panel.Controls.Add(taiKhoan);
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            UCQLnhanvien nv = new UCQLnhanvien();
            Panel.Controls.Clear();
            Panel.Controls.Add(nv);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Panel.Controls.Clear();

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnHiden_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có Muốn Thoát chương Trình Không", "Thông Báo", MessageBoxButtons.YesNo);
            int checkban = Ban.ckeckbanthoat();
            if (checkban != 0)
            {
                MessageBox.Show("còn bàn  chưa thanh toán ", "Cảnh Báo", MessageBoxButtons.OK);
                return;
            }
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
