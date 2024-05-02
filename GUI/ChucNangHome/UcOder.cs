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

//using System.Web.UI.WebControls;


namespace GUI.ChucNangHome
{
    public partial class UcOder : UserControl
    {
        ChiTietHD_DAL cthd = new ChiTietHD_DAL();
       HoaDon_BUS HoaDon = new HoaDon_BUS();
        MenuHD_DAL menuHD = new MenuHD_DAL();
        DataBase_DAL DB = new DataBase_DAL();
        Ban_DAL banDAL = new Ban_DAL();
       
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
           
            List<Ban> dsban = banDAL.loadBan();

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

                // Set ForeColor of button text
                btn.ForeColor = Color.FromArgb(31, 166, 243);

                switch (ban.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.BlueViolet;
                        btn.ForeColor = Color.White; // Set the text color for 'Trống' status
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
            CB.DataSource = banDAL.loadBan();
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

        public int mabn;
        void Btn_Click(object sender, EventArgs e)
        {
            //Button clickedButton = sender as Button;

            // Ban ban = clickedButton.Tag as Ban;
            // lv1.Tag =(sender as Button).Tag;
            int maban = ((sender as Button).Tag as Ban).MaBan;
                Show(maban);
            mabn= maban;
     
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
    

            if (mahd == -1)
            {
                if (soluong < 1)
                {
                    MessageBox.Show("tạo hóa đơn số lượng không hợp lệ!","Cảnh Báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    HoaDon.ThemHD(mabn, manv);
                    cthd.NhapCT(HoaDon.getMaxMaHD(), mamon, soluong);
                    Show(mabn);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Thêm món ", "Thông báo", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    cthd.NhapCT(mahd, mamon, soluong);
                    Show(mabn);
                }

              
               
            }
            DSban.Controls.Clear();
            ThemBan();





        }

        private void gb1_Click(object sender, EventArgs e)
        {

        }
        //thanh toan
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            int mahd = HoaDon.layMaHD(mabn);
            if(mahd != -1)
            {
                DialogResult result = MessageBox.Show("Thanh toan ", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
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
            DSban.Controls.Clear();
            ThemBan();
        }

       

        private void txtChuyen_Click(object sender, EventArgs e)
        {
            int mabanchuyen = (cb.SelectedItem as Ban).MaBan;
            DialogResult result = MessageBox.Show("ban có muôn chuyển bàn không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                banDAL.Chuyenban(mabn,mabanchuyen);
            }
            DSban.Controls.Clear();
            ThemBan();
            Show(mabanchuyen);

        }

        private void txtmon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

