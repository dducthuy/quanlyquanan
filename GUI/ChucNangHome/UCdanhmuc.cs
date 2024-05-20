using BUS;
using BUS.BUS;
using DTO;
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

namespace GUI.ChucNangHome
{
    public partial class UCdanhmuc : UserControl
    {
        DanhMuc_BUS dn = new DanhMuc_BUS(); 
        DanhMuc DanhMuc = new DanhMuc();
        public UCdanhmuc()
        {
            InitializeComponent();
            dgv1.DataSource = dn.GetData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
             string ten = txtTim.Text;
            dgv1.DataSource = dn.TimKiem(ten);

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv1.SelectedRows)
            {


                txtId.Text = row.Cells[0].Value.ToString();
                txtten.Text = row.Cells[1].Value.ToString();
          

            }
            txtId.Enabled = false;
           
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
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
                txtId.Enabled = true;
              

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          DanhMuc.MaDM =txtId.Text;
            DanhMuc.TenDM=txtten.Text;
            try
            {
            dn.ThemDanhMuc(DanhMuc);

            }
            catch(AggregateException ez) {
                MessageBox.Show(ez.Message);
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv1.DataSource = dn.GetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DanhMuc.MaDM = txtId.Text;
            DanhMuc.TenDM = txtten.Text;
            
            try
            {
                dn.Sua(DanhMuc);

            }
            catch (AggregateException ez)
            {
                MessageBox.Show(ez.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv1.DataSource = dn.GetData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DanhMuc.MaDM= txtId.Text;

            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa Bàn không  ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   dn.Xoa(DanhMuc);

                }


            }
            catch (AggregateException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv1.DataSource = dn.GetData();
        }
    }
}
