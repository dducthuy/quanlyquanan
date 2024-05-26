using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.BUS;
using DTO;
using Guna.UI2.WinForms;
namespace GUI.ChucNangHome
{
    public partial class UCqlban : UserControl
    {
        public UCqlban()
        {
            InitializeComponent();
            dgv1.DataSource = BanBUS.GetData();
        }
        Ban B =new Ban();
        Ban_BUS BanBUS = new Ban_BUS();
        
        private void btnThem_Click(object sender, EventArgs e)
        {

            B.Tenban = txtten.Text;
            try
            {
                bool check = BanBUS.ThemBan(B);
                if (check)
                {
                    MessageBox.Show("Thêm Thành công");
                    dgv1.DataSource = BanBUS.GetData();

                }

            }
            catch(AggregateException ex) { MessageBox.Show(ex.Message); }
           

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Enabled = false;
            foreach (DataGridViewRow row in dgv1.SelectedRows)
            {

                txtId.Text = row.Cells[0].Value.ToString();
                txtten.Text = row.Cells[2].Value.ToString();

            }
        }

        private void btnnew_Click(object sender, EventArgs e)
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
                txtId.Enabled = true;
                dgv1.DataSource = BanBUS.GetData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maBan;
                if (!int.TryParse(txtId.Text, out maBan))
                {
                    MessageBox.Show("Không Thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                B.MaBan = maBan;
                B.Tenban = txtten.Text;

                bool check = BanBUS.Sua(B);
                if (check)
                {
                    MessageBox.Show("Sửa thành công");
                    dgv1.DataSource = BanBUS.GetData();
                }
            }
         
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        // xoa

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int maBan;
                if (!int.TryParse(txtId.Text, out maBan))
                {
                    MessageBox.Show("Không Thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                B.MaBan = maBan;

                DialogResult result = MessageBox.Show("Bạn có muốn xóa Bàn Không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string message = BanBUS.Xoa(B);
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv1.DataSource = BanBUS.GetData();
                }
            }

            catch (Exception ex)
            {
                string customMessage = "Bàn còn giữ liệu liên quan. Không thể xóa.";
                MessageBox.Show(customMessage, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            string key = txtTim.Text;
            dgv1.DataSource = BanBUS.TimKiem(key);
            
        }

        
    }
}
