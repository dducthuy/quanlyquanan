using Guna.UI2.WinForms;
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
namespace GUI.ChucNangHome
{
    public partial class UCQLnhanvien : UserControl
    {
        public UCQLnhanvien()
        {
            InitializeComponent();
          
            dgv1.DataSource = NVbus.GetData();
        }
        NhanVien_BUS NVbus = new NhanVien_BUS();
        NhanVien NV = new NhanVien();

       
      
    
       
        private void btnNew_Click(object sender, EventArgs e)
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
            txtMaNV.Enabled = true;
            txtMaTK.Enabled = true;
            dgv1.DataSource = NVbus.GetData();


        }

        private void gb1_Click(object sender, EventArgs e)
        {

        }


        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv1.SelectedRows)
            {
                txtMaTK.Enabled = false;

                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                date.Text = row.Cells[3].Value.ToString();
                txtMaTK.Text = row.Cells[4].Value.ToString();   
            }
            txtMaTK.Enabled = false ;
            txtMaNV.Enabled = false ;   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NV.MaNV = txtMaNV.Text;
            NV.HoTen = txtTen.Text;
            NV.SDT = txtSDT.Text;
            NV.NgaySinh = date.Value.ToString("yyyy-MM-dd"); 

            NV.MaTK = txtMaTK.Text;
            NV.MaTK = txtMaTK.Text;
            try
            {

                bool check = NVbus.Sua(NV);
                MessageBox.Show("sửa thành công!");
            dgv1.DataSource = NVbus.GetData();

            }
            catch (AggregateException ez)
            {
                MessageBox.Show(ez.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NV.MaNV = txtMaNV.Text; 
            NV.HoTen = txtTen.Text;
            NV.SDT = txtSDT.Text;
          
                
            NV.MaTK = txtMaTK.Text;
            if(txtMaTK.Text == "Admin")
            {
                MessageBox.Show("Không thế xóa Admin");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa Nhân viên Không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {

                    MessageBox.Show(NVbus.xoa(NV));
                    dgv1.DataSource = NVbus.GetData();


                }
            }
            catch (AggregateException ez)
            {
                MessageBox.Show(ez.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không Thể xóa còn dữ Liệu liên quan");

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string key = txtTim.Text;
            dgv1.DataSource = NVbus.tim(key);

        }

        private void dtpNS_ValueChanged(object sender, EventArgs e)
        {
       
        }


        private void txtThem_Click(object sender, EventArgs e)
        {
            NV.MaNV = txtMaNV.Text;
            NV.HoTen = txtTen.Text;
            NV.SDT = txtSDT.Text;
            NV.NgaySinh = date.Value.ToString("yyyy-MM-dd"); // Đảm bảo định dạng chuỗi là 'yyyy-MM-dd'

            NV.MaTK = txtMaTK.Text;

            try
            {
                bool check = NVbus.ThemNV(NV);
                MessageBox.Show("Thêm thông ti thành công!");
                dgv1.DataSource = NVbus.GetData();
            }
            catch (AggregateException ez)
            {
                MessageBox.Show(ez.Message);
            }
        }
    }
}
