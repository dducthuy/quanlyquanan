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
    


    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        TaiKhoanBUS taikhoan = new TaiKhoanBUS();
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // login
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTK.Text;
            string MatKhau = txtMK.Text;

           try 
            {

                TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
                var check = taiKhoanBUS.checkLogin(TenDangNhap, MatKhau);
                string matk = check.Item2;
                string quyen = check.Item1; 
               
                MessageBox.Show("Đăng Nhập Thành Công Quyền: "+quyen,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home home = new Home(matk,quyen);
                home.ShowDialog();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHiden_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal) 
            {

                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
