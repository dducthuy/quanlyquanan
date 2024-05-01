using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.InterFace;
using DTO;

namespace DAL
{
    public class Ban_DAL : InQuanLy
    {
        DataBase_DAL DBConnect = new DataBase_DAL();
      

        public static int TableWidth = 85;
        public static int TableHeight = 85;
        
       

        public bool Them(object obj)
        {
            Ban ban = (Ban)obj;
            string sql = string.Format("INSERT INTO BanAn ( TrangThai, Tenban) VALUES (N'Trống', '{0}')", ban.Tenban);
            DBConnect.thucthisql(sql);
            return true;
        }

        public void Sua(object obj)
        {
            Ban ban = (Ban)obj;
            string sql = string.Format("UPDATE BanAn SET TrangThai = N'Trống', Tenban = '{0}' WHERE MaBan = '{1}'", ban.Tenban, ban.MaBan);
            DBConnect.thucthisql(sql);
        }

        public bool Xoa(object obj)
        {
            Ban ban = (Ban)obj;
            string queryDelete = string.Format("DELETE FROM BanAn WHERE MaBan = {0}", ban.MaBan);
            DBConnect.thucthisql(queryDelete);
            return true;
        }

        public DataTable TimKiem(string Key)
        {
            string querySelect = "SELECT * FROM BanAn WHERE Tenban LIKE '%" + Key.Trim() + "%'";
            return DBConnect.getData(querySelect);
        }

        public DataTable getData()
        {
            string sql = "SELECT * FROM BanAn";
            return DBConnect.getData(sql);
        }

        public int Check(string teban)
        {
            string sql = "SELECT COUNT(*) FROM BanAn WHERE TenBan = '" + teban.Trim() + "'";
            return DBConnect.CheckID(teban, sql);
        }

        // danh sách bàn
        public List<Ban> loadBan()
        {
            string sql = "select * from BanAn";
            List<Ban> list = new List<Ban>();
            DataTable dataTable = DBConnect.getData(sql);
            foreach(DataRow row in dataTable.Rows)
            {
                Ban B = new Ban(row);
                list.Add(B);
            }
            return list;    
        }
        public void Chuyenban(int maban, int mabandi)
        {
            string sql = string.Format("EXEC HoaDonchuyenban @idBanDau = {0}, @idBanMoi = {1}",maban,mabandi);
            DBConnect.thucthisql(sql);
          //  return true;
        }  
     
    }
}
