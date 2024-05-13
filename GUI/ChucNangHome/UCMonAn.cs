﻿using Guna.UI2.WinForms;
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
using DTO;
using DAL;
namespace GUI.ChucNangHome
{
    public partial class UCMonAn : UserControl
    {
        MonAn_BUS monbusc = new MonAn_BUS();
        MonAn ma = new MonAn(); 
        public UCMonAn()
        {
            InitializeComponent();
            dgv1.DataSource = monbusc.LayDuLieu();
            loaddanhmuc();
        }

        private void UCMonAn_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ma.TenMon = txtTen.Text;
            ma.MaMon = txtId.Text;
            ma.Gia = float.Parse(txtGia.Text);
            ma.MaDM = (cbDM.SelectedItem as DanhMuc).MaDM;
            try
            {
                bool check = monbusc.SuaMonAn(ma);
                if (check)
                {
                    MessageBox.Show("sửa thnahf công");
                    dgv1.DataSource = monbusc.LayDuLieu();

                }
            }
            catch(AggregateException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in gb1.Controls)
            {
                if (control is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)control;
                    textBox.Text = "";
                    txtGia.Text = "0";
                }
                else if (control is Guna2ComboBox)
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }

            }
            txtId.Enabled = true;
            dgv1.DataSource = monbusc.LayDuLieu();

        }

        private void tbnThem_Click(object sender, EventArgs e)
        {
            ma.TenMon = txtTen.Text;
            ma.MaMon = txtId.Text;
            ma.Gia = float.Parse(txtGia.Text);
            ma.MaDM = (cbDM.SelectedItem as DanhMuc).MaDM;
            try
            {
                bool checck = monbusc.ThemMonAn(ma);
                if (checck)
                {
                    MessageBox.Show("THêm thành công!");
                    dgv1.DataSource = monbusc.LayDuLieu();

                }

            }
            catch (AggregateException ez)
            {
                MessageBox.Show(ez.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");    
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv1.SelectedRows)
            {
              

                txtId.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtGia.Text = row.Cells[2].Value.ToString();
                cbDM.Text = row.Cells[3].Value.ToString();
             
            }
            txtId.Enabled = false;
           


        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string key =txtTim.Text;
           dgv1.DataSource = monbusc.TimKiem(key);


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
      
              ma.MaMon = txtId.Text;
           
            try
            {
                MessageBox.Show(monbusc.XoaMonAn(ma));
                dgv1.DataSource = monbusc.LayDuLieu();

            }
            catch (AggregateException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        void loaddanhmuc()
        {
            DanhMuc_DAL dmDAL = new DanhMuc_DAL();

            List<DanhMuc> dsdm = dmDAL.Laydsdm();
            cbDM.DataSource = dsdm;
            cbDM.DisplayMember = "TenDM";
            dgv1.DataSource = monbusc.LayDuLieu();
            dgv1.Columns[0].HeaderText = "Mã";
            dgv1.Columns[1].HeaderText = "Tên ";
            dgv1.Columns[2].HeaderText = "Giá";
            dgv1.Columns[3].HeaderText = "Danh Mục";
            dgv1.Columns[4].HeaderText = "Lượt bán";

        }
        private void cbDM_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
