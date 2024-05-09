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
using DTO;
using BUS;

namespace GUI
{

    public partial class Home : Form
    {
       
        TaiKhoanBUS TKbus= new TaiKhoanBUS();
        NhanVien_BUS N = new NhanVien_BUS();    
        public Home()
        {
            InitializeComponent();
        }

        public string MaTK {  get; set; }
        public string MaNV {  get; set; }   
        public Home(string MaTK)
        {
            InitializeComponent();
            this.MaTK = MaTK;
            this.MaNV = layMaNV(MaTK);
            txtMaNV.Text = this.MaNV;
     
        }

        string layMaNV(string maTK)
        {
            string MaNV = N.laymnv(maTK);
            return MaNV;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {


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

       

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
        }
        // món
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UCMonAn qlmon = new UCMonAn();
            Panel.Controls.Clear();
            Panel.Controls.Add(qlmon);
        }
        //bàn
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UCqlban uCqlban = new UCqlban();
            Panel.Controls.Clear();
            Panel.Controls.Add((uCqlban));
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string manv = this.MaNV;
            UcOder O =new UcOder(manv);
            Panel.Controls.Clear();
            Panel.Controls.Add((O));

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_thongke tk = new UC_thongke();
            Panel.Controls.Clear();
            Panel.Controls.Add((tk));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap d = new DangNhap();
           
            d.ShowDialog();
        }

        private void btndanhmuc_Click(object sender, EventArgs e)
        {
            UCdanhmuc tk = new UCdanhmuc();
            Panel.Controls.Clear();
            Panel.Controls.Add((tk));
        }
    }
}
