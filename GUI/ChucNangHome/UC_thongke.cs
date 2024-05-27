using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;
using DAL;
using DTO;
using GUI.report;
namespace GUI.ChucNangHome
{
    public partial class UC_thongke : UserControl
    {
        HoaDon_BUS hd = new HoaDon_BUS();
        ChitietHD_BUS ch = new ChitietHD_BUS();
        MonAn_BUS mon = new MonAn_BUS();    
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

            tron.Titles.Clear();
         
            chart1.Visible = false; 
            tron.Visible = true;    

          
            string ngay = Ngay.Value.ToString("yyyy-MM-dd");

       
            DataTable dt = hd.DTNgay(ngay);  
            DataTable dt1 = mon.spbanchay(ngay);  

         
            dgv1.DataSource = dt;
            dgv1.Columns[0].HeaderText = "Tổng Tiền";
            dgv1.Columns[1].HeaderText = "Mã Hóa Đơn";
            dgv1.Columns[2].HeaderText = "Ngày tạo";
            dgv1.Columns[3].HeaderText = "Ngày thanh toán";
            dgv1.Columns[4].Visible = false;

         
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

            tron.Series.Clear();

            Series series = new Series
            {
                Name = "Series1",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Doughnut,

            };
            
            



            foreach (DataRow row in dt1.Rows)
            {
                string tenMon = row["TenMon"].ToString();
                int totalQuantitySold = Convert.ToInt32(row["ban"]);
                series.Points.AddXY(tenMon, totalQuantitySold);
            }
            tron.Titles.Add("sản phẩm bán chạy ngày");
            tron.Series.Add(series);
        }



        private void cbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Visible = true;
            tron.Visible = false;
            chart1.Series["Doanh Thu"].Points.Clear();

            chart1.Titles.Clear();
            chart1.ChartAreas[0].Name = "MainArea";

            chart1.Titles.Add("Biểu đồ doanh thu các ngày trong tháng");
            chart1.ChartAreas["MainArea"].AxisX.Title = "Ngày";
            chart1.ChartAreas["MainArea"].AxisY.Title = "VNĐ";

            int nam = (int)cnnam.Value;
            int thang = int.Parse(cbthang.Text);
 
            DataTable data = hd.DTThangnam(thang,nam);
            for (int i = 0; i < dgv1.Columns.Count; i++)
            {
                dgv1.Columns[i].Visible = true;
            }

            dgv1.DataSource= data;
            dgv1.Columns[0].HeaderText = "Đơn Bán";
            dgv1.Columns[1].HeaderText = "Tổng Tiền ";
            dgv1.Columns[2].HeaderText = "Ngày";
            dgv1.Columns[3].Visible = false;
            dgv1.Columns[4].Visible = false;


            int tongCong = 0;
            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    int giaTri;
                    if (int.TryParse(row[1].ToString(), out giaTri))
                    {
                        DateTime ngayThanhToan;
                        if (DateTime.TryParse(row["ngay"].ToString(), out ngayThanhToan))
                        {
                            chart1.Series["Doanh Thu"].Points.AddXY(ngayThanhToan.ToString("dd"), giaTri);
                         

                            tongCong += giaTri;
                        }
                    }
                }
            }
            txttongtien.Text = tongCong.ToString("c");
           
        }

        private void Nam_ValueChanged(object sender, EventArgs e)
        {
            chart1.Visible = true;
            tron.Visible = false;

            chart1.Series["Doanh Thu"].Points.Clear();
          
            chart1.Titles.Clear();
            chart1.ChartAreas[0].Name = "MainArea";

            chart1.ChartAreas["MainArea"].AxisX.Title = "Tháng";
            chart1.ChartAreas["MainArea"].AxisY.Title = "VNĐ";
            chart1.Titles.Add("Biểu đồ doanh thu các Tháng trong năm");


            int nam = (int)Nam.Value;
      
            DataTable data = hd.dtcacthang(nam);
            //reset colum
            for (int i = 0; i < dgv1.Columns.Count; i++)
            {
                dgv1.Columns[i].Visible = true;
            }
            dgv1.DataSource = data;
            dgv1.Columns[0].HeaderText = "Đơn Bán";
            dgv1.Columns[1].HeaderText = "Tổng Tiền ";
            dgv1.Columns[2].HeaderText = "Tháng";
            
         
          dgv1.Columns[3].Visible = false;
            dgv1.Columns[4].Visible = false;

            int tongCong = 0;
            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    int giaTri;
                    if (int.TryParse(row[1].ToString(), out giaTri))
                    {
                        chart1.Series["Doanh Thu"].Points.AddXY(row[2].ToString(), giaTri);
                      //  chart1.Series["Đơn Bán"].Points.AddXY(row[0].ToString(), row["SoDonHang"].ToString());
                        tongCong += giaTri;
                    }
                }
            }
            txttongtien.Text = tongCong.ToString("c");
       

        }

      
        

        private void dgv1_Click(object sender, EventArgs e)
        {

        }
        // Mở report cho từng kiểu thống kê
       

        private void excell_Click_1(object sender, EventArgs e)
        {

            if (dgv1.Columns.Count >= 2 && dgv1.Columns[2].HeaderText == "Tháng")
            {
                int nam = (int)Nam.Value;
                DataTable data = hd.dtcacthang(nam);
                doanhthunam dt = new doanhthunam();
                dt.SetDataSource(data);
                rpthoadon rpthoadon = new rpthoadon();
                rpthoadon.rptv1.ReportSource = dt;
                rpthoadon.Show();

            }
            else if (dgv1.Columns.Count >= 2 && dgv1.Columns[2].HeaderText == "Ngày")
            {
                int nam = (int)cnnam.Value;
                int thang = int.Parse(cbthang.Text);
                DataTable data = hd.DTThangnam(thang, nam);
                thongkethang dt = new thongkethang();
                dt.SetDataSource(data);
                rpthoadon rpthoadon = new rpthoadon();
                rpthoadon.rptv1.ReportSource = dt;
                rpthoadon.Show();



            }
            else if(dgv1.Columns.Count ==0)
            {
                MessageBox.Show("chưa có thông tin thống kê", "Thông báo");
            }


            else  
            {
                string ngay = Ngay.Value.ToString("yyyy-MM-dd"); // Đảm bảo định dạng chuỗi là 'yyyy-MM-dd'
                DataTable data = hd.DTNgay(ngay);
                ngay2 dt = new ngay2();
                dt.SetDataSource(data);
                rpthoadon rpthoadon = new rpthoadon();
                rpthoadon.rptv1.ReportSource = dt;
                rpthoadon.Show();

            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            
            if (dgv1.Columns.Count >= 2 && dgv1.Columns[1].HeaderText == "Mã Hóa Đơn")
            {
                foreach (DataGridViewRow row in dgv1.SelectedRows)
                {


                    txtmahd.Text =row.Cells[1].Value.ToString();
                   


                }

                DataTable dt = ch.layhd_tk(int.Parse(txtmahd.Text));
                    hdtk11 hd = new hdtk11();
                    hd.SetDataSource(dt);
                rpthoadon rp = new rpthoadon();
                rp.rptv1.ReportSource = hd;
                rp.Show();


            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tron_Click(object sender, EventArgs e)
        {

        }
    }
}
