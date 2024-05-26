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
using DAL;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms.Layout;
using BUS.BUS;
using GUI.report;

//using System.Web.UI.WebControls;


namespace GUI.ChucNangHome
{
    public partial class UcOder : UserControl
    {
        ChitietHD_BUS cthd = new ChitietHD_BUS();
       HoaDon_BUS HoaDon = new HoaDon_BUS();
        MenuHD_DAL menuHD = new MenuHD_DAL();
        DataBase_DAL DB = new DataBase_DAL();
        Ban_BUS Ban = new Ban_BUS();
        ChitietHD_BUS ct = new ChitietHD_BUS();
       
        public string MaNV { get; set; }

        public UcOder(string maNV)
        {
            InitializeComponent();
            this.MaNV = maNV;
            ThemBan();
            loaddanhmuc();
            loadban(cb);
            
        }

        public UcOder()
        {
            InitializeComponent();
            
        }
        // thêm btn v
        public void ThemBan()
        {
           
            List<Ban> dsban = Ban.loadBan();

            foreach (Ban ban in dsban)
            {
                Button btn = new Button()
                {
                    Width = Ban_DAL.TableWidth,
                    Height = Ban_DAL.TableHeight
                };

                btn.Click += Btn_Click;
                btn.Tag = ban;

                btn.Text = ban.Tenban + Environment.NewLine + ban.TrangThai;

 
                btn.ForeColor = Color.FromArgb(31, 166, 243);

                switch (ban.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.BlueViolet;
                        btn.ForeColor = Color.White; 
                        break;
                    default:
                        btn.BackColor = Color.White;
                        break;
                }

              DSban.Controls.Add(btn);
            }
        }
        public void loadban(ComboBox CB)
        {
            CB.DataSource = Ban.loadBan();
            CB.DisplayMember = "TenBan";  
        }
        public void Show(int maban)
        {
            lv1.Items.Clear();

            List<MenuHD> lv = menuHD.laydsmenu(maban);
            float TongTien = 0;
            foreach (MenuHD item in lv)
            {
                ListViewItem listv = new ListViewItem(item.TenMon.ToString());
                listv.SubItems.Add(item.SoLuong.ToString());
                listv.SubItems.Add(item.Gia.ToString());
                listv.SubItems.Add(item.Tong.ToString());
                TongTien += item.Tong.Value;
          
                lv1.Items.Add(listv);
            }
            txttongtien.Text = TongTien.ToString("c"); 
        }
        //public void Show(int maban)
        //{
        //    lv1.Items.Clear();

        //    List<MenuHD> lv = menuHD.laydsmenu(maban);
        //    decimal TongTien = 0; // Change the type to decimal
        //    foreach (MenuHD item in lv)
        //    {
        //        ListViewItem listv = new ListViewItem(item.TenMon.ToString());
        //        listv.SubItems.Add(item.SoLuong.ToString());
        //        listv.SubItems.Add(item.Gia.ToString()); // No formatting needed here
        //        listv.SubItems.Add(item.Tong.HasValue ? item.Tong.Value.ToString("0.00") : "0"); // Format to two decimal places
        //        TongTien += (decimal)(item.Tong ?? 0); // Convert nullable float to decimal

        //        lv1.Items.Add(listv);
        //    }
        //    txttongtien.Text = String.Format("{0:C}", TongTien); // Format the total amount as currency
        //}


        public int mabn;
        void Btn_Click(object sender, EventArgs e)
        {
          
            int maban = ((sender as Button).Tag as Ban).MaBan;
                Show(maban);
            mabn= maban;
            txtban.Text = ((sender as Button).Tag as Ban).Tenban.ToString();

        }
    
        void loaddanhmuc()
        {
            DanhMuc_DAL dmDAL = new DanhMuc_DAL();

            List<DanhMuc> dsdm = dmDAL.Laydsdm();
            txtdanhmuc.DataSource = dsdm;
            txtdanhmuc.DisplayMember = "TenDM";

        }
        void loadMon(string MaDM)
        {
            MonAn_DAL monAn_DAL = new MonAn_DAL();
            List<MonAn> dsm =   monAn_DAL.laydsmon(MaDM);
            txtmon.DataSource = dsm;
            txtmon.DisplayMember = "TenMon";
        }

        private void txtdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaDM;
           ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            DanhMuc selected = cb.SelectedItem as DanhMuc;
            MaDM = selected.MaDM;
            loadMon(MaDM);
        }
        // them mon vao hoa don
        private void btnThêm_Click(object sender, EventArgs e)
        {
            int mahd = HoaDon.layMaHD(mabn);
            string manv = this.MaNV;
            string mamon = (txtmon.SelectedItem as MonAn).MaMon;
            int soluong = (int)sl.Value;
            if (string.IsNullOrEmpty(txtban.Text))
            {
                MessageBox.Show("Chọn một bàn để thêm món");

            }
            else
            {

            if (mahd == -1)
            {
                if (soluong < 1)
                {
                    MessageBox.Show("tạo hóa đơn số lượng không hợp lệ!","Cảnh Báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    HoaDon.ThemHD(mabn, manv);
                    cthd.nhapCT(HoaDon.getMaxMaHD(), mamon, soluong);
                    Show(mabn);
                }
            }
            else
            {
                int check = cthd.ckeckmonhoadon(mahd, mamon);
             
                if (check < 1)
                {
                    if (soluong < 1)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0 khi thêm món mới.");
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Món này chưa có trong hóa đơn. Bạn có muốn thêm vào không?", "Thông báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            cthd.nhapCT(mahd, mamon, soluong);
                            Show(mabn); 
                        }
                    }
                }
                else
                {
                    if (soluong < 1)
                    {
                        DialogResult result = MessageBox.Show(" Bạn có muốn giảm sô lượng không?", "Thông báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            cthd.nhapCT(mahd, mamon, soluong);
                            Show(mabn);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(" Bạn có muốn tiếp tục thêm?", "Thông báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            cthd.nhapCT(mahd, mamon, soluong);
                            Show(mabn);
                        }
                    }
                      
                   
                }
            }
            DSban.Controls.Clear();
            ThemBan();
            }
        }

        private void gb1_Click(object sender, EventArgs e)
        {

        }
        //thanh toan
        private void guna2Button1_Click(object sender, EventArgs e)
        {
         
            int mahd = HoaDon.layMaHD(mabn);
            if (string.IsNullOrEmpty(txtban.Text))
            {
                MessageBox.Show("chưa chọn bàn");

            }
            else
            {

            if (mahd != -1)
            {
                DataTable dt = ct.layhd(mabn);
                hoadon1 hd = new hoadon1();
                hd.SetDataSource(dt);
                rpthoadon rpthoadon = new rpthoadon();
                rpthoadon.rptv1.ReportSource = hd;
                rpthoadon.Show();
                DialogResult result = MessageBox.Show("Bạn có muốn thanh toán không! ", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    HoaDon.checkout(mahd,mabn);
                    Show(mabn);
                }
                DSban.Controls.Clear();
                ThemBan();


            }
            else
            {
                MessageBox.Show("bàn chưa có hóa đơn","Cảnh báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            }
          
        }

       

        private void txtChuyen_Click(object sender, EventArgs e)
        {
            string trangthai = (cb.SelectedItem as Ban).TrangThai;
            int mabanchuyen = (cb.SelectedItem as Ban).MaBan;
            if (string.IsNullOrEmpty(txtban.Text))
            {
                MessageBox.Show("Bàn không có để truyển");

            }
            else
            {
                if(mabanchuyen == mabn)
                {
                    MessageBox.Show("Không thể chuyển");
                    return;

                }
                if (trangthai != "Trống")
                {
                    DialogResult result = MessageBox.Show("ban có muôn gộp bàn không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        Ban.chuyenban(mabn, mabanchuyen);
                        DSban.Controls.Clear();
                        ThemBan();
                        Show(mabanchuyen);
                    }


                }
                else
                {
                    DialogResult result = MessageBox.Show("bạn có muốn chuyền bàn hay không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        Ban.chuyenban(mabn, mabanchuyen);
                        DSban.Controls.Clear();
                        ThemBan();
                        Show(mabanchuyen);
                    }
                }


            }
        }

      
    }
}

