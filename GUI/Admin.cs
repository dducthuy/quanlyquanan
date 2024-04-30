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
    }
}
