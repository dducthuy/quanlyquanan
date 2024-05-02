using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
namespace GUI.ChucNangHome
{
    public partial class UC_thongke : UserControl
    {
        HoaDon_BUS hd = new HoaDon_BUS();
        public UC_thongke()
        {
            InitializeComponent();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void UC_thongke_Load(object sender, EventArgs e)
        {

        }

        private void listban_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ngay_ValueChanged(object sender, EventArgs e)
        {
            string ngay =  Ngay.Value.ToString("yyyy-MM-dd"); // Đảm bảo định dạng chuỗi là 'yyyy-MM-dd'
            DataTable dt = hd.DTNgay(ngay);
            dgv1.DataSource = dt;
            int tongCong = 0;
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int giaTri;
                    if (int.TryParse(row[0].ToString(), out giaTri))
                    {
                        tongCong += giaTri;
                    }
                }
            }
            txttongtien.Text = tongCong.ToString("c");

        }



        private void cbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = (int)cnnam.Value;
            int thang = int.Parse(cbthang.Text);

            DataTable data = hd.DTThangnam(thang,nam);
            dgv1.DataSource= data;
            int tongCong = 0;
            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    int giaTri;
                    if (int.TryParse(row[0].ToString(), out giaTri))
                    {
                        tongCong += giaTri;
                    }
                }
            }
            txttongtien.Text = tongCong.ToString("c"); 
         
        }

        private void Nam_ValueChanged(object sender, EventArgs e)
        {
            int nam = (int)Nam.Value;
            int thang = 0;
            DataTable data = hd.DTThangnam(thang, nam);
            dgv1.DataSource = data;
            int tongCong = 0;
            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    int giaTri;
                    if (int.TryParse(row[0].ToString(), out giaTri))
                    {
                        tongCong += giaTri;
                    }
                }
            }
            txttongtien.Text = tongCong.ToString("c");

        }
    }
}
