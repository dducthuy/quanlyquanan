using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    }
}
