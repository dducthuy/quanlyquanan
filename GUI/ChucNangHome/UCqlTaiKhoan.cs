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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web.UI.WebControls;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace GUI.ChucNangHome
{
    public partial class UCqlTaiKhoan : UserControl
    {

        TaiKhoanBUS TKbus =new TaiKhoanBUS();
        public UCqlTaiKhoan()
        {
            InitializeComponent();
      
            guna2DataGridView1.DataSource = TKbus.getData();
            DSquyen(cbDM);

        }
        //private async void delay()
        //{
        //    await Delay_grv();
        //}
        ////hàm delay
        //public async Task Delay_grv()
        //{ 
        //    await Task.Delay(1000);// 1s
        //    guna2DataGridView1.DataSource = TKbus.getData();
           
        //}
        

        //Thêm 
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTK.Text;
            string matKhau = txtMk.Text;
            string maTK = txtMaTK.Text;
            string maQ = cbDM.Text;

            try
            {
                bool check = TKbus.Them(tenDangNhap, matKhau, maTK, maQ);
                if (check) 
                {
                  MessageBox.Show("Thêm tài khoản thành công!");
                  guna2DataGridView1.DataSource =  TKbus.getData();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


            

        }
        public void DSquyen(Guna2ComboBox CB)
        {
            CB.DataSource = TKbus.Dsquyen();
            CB.DisplayMember = "MaQ";
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            foreach (DataGridViewRow row in guna2DataGridView1.SelectedRows)
            {
                txtMaTK.Enabled = false;

                txtMaTK.Text = row.Cells[0].Value.ToString();
                txtTK.Text = row.Cells[1].Value.ToString();
                txtMk.Text = row.Cells[2].Value.ToString();
                cbDM.Text = row.Cells[3].Value.ToString();

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {    
          
            string tenDangNhap = txtTK.Text;
            string matKhau = txtMk.Text;
            string maTK = txtMaTK.Text;
            string maQ = cbDM.Text;
            try
            {
                bool check = TKbus.Sua(maTK, tenDangNhap, matKhau, maQ);
                if (check)
                {
                    MessageBox.Show("sửa thành công!");
                    guna2DataGridView1.DataSource = TKbus.getData();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in gb1.Controls)
            {
                if (control is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)control;
                    textBox.Text = "";
                }
                else if (control is Guna2ComboBox)
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }

            }
            txtMaTK.Enabled = true;
            guna2DataGridView1.DataSource = TKbus.getData();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string TK =txtTim.Text;
            guna2DataGridView1.DataSource = TKbus.tim(TK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTK.Text;
            string matKhau = txtMk.Text;
            string maTK = txtMaTK.Text;
            string maQ = cbDM.Text;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tài Khoản Không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if(result == DialogResult.Yes)
                {

                    MessageBox.Show(TKbus.Xoa(maTK, tenDangNhap, matKhau, maQ));
                    guna2DataGridView1.DataSource = TKbus.getData();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bạn cần xóa nhân viên trước :" + ex);
            }
         

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbDM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
