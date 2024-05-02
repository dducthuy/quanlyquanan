using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class HoaDon_DAL
    {    


        DataBase_DAL DB = new DataBase_DAL();   
        public HoaDon_DAL() { }
        // Lay maHd
        public int layMaHD(int MaBan)
        {
            string sql =string.Format("SELECT * FROM HoaDon WHERE MaBan = '{0}' AND TinhTrang = '1'",MaBan);
            DataTable dt = DB.getData(sql);

            if (dt.Rows.Count > 0)
            {
                HoaDon hoaDon = new HoaDon(dt.Rows[0]);
                return hoaDon.MaHD;
            }

            return -1;
        }
        public void ThemHD(int MaBan , string MaNV)
        {
            string sql = string.Format("EXEC InsertHoaDon {0}, {1}", MaNV,MaBan);
            DB.thucthisql(sql);
            

        }
        public int getMaxMaHD()
        {
            string sql = string.Format("SELECT MAX(MaHD) FROM HoaDon");
            string s = sql;
            try
            {
                return DB.CheckID(sql, sql);
            }
            catch
            {
                return 1;
            }
        }
        // cap nhat lai 

        public  void checkout(int MaHD,int MaBan)
        {
            string sql = string.Format("EXEC checkout @MaHD = {0}, @MaBan = {1} ", MaHD,MaBan);
            DB.thucthisql(sql);
        }

        public DataTable DTThangnam(int ngay, int nam)
        {
            string sql = string.Format("exec [dbo].[Hoadonthangnam] {0},{1}", ngay,nam);
           return DB.getData(sql);
        }
        public DataTable DTNgay(string ngay)
        {
            string sql = string.Format("EXEC HoadonNgay '{0}'", ngay);
          return  DB.getData(sql);
        }
    }
}
