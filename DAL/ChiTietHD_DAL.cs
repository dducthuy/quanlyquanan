using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{

    
    public class ChiTietHD_DAL
    {
        DataBase_DAL DB = new DataBase_DAL();

        public ChiTietHD_DAL() { }
        public List<ChiTietHoaDon> DschitietHD(int MaHD)
        {
            string sql = "select * from ChiTietHoaDon Where MaHD =" + MaHD.ToString() + "";
            List<ChiTietHoaDon>DS =new List<ChiTietHoaDon>();
            DataTable dataTable = DB.getData(sql);
            foreach(DataRow dr in dataTable.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(dr);
                DS.Add(chiTietHoaDon);
            }
            return DS;
        }
        public void  NhapCT(int MaHD, string MaMon, int soluong)
        {
            string sql = string.Format("EXEC InsertChiTietHoaDon @MaHD = {0}, @MaMon = '{1}', @SoLuong = {2}", MaHD, MaMon, soluong);
            DB.thucthisql(sql);

     
           
        }
        public int ckeckmonhoadon(int mahd,string mamon)
        {
            string sql = string.Format("SELECT COUNT(*) FROM ChiTietHoaDon WHERE MaHD = {0} AND MaMon = '{1}';", mahd,mamon);
            string ko = "";
           return DB.CheckID(ko, sql);
        }
        public DataTable layhd(int maban)
        {
            string sql = string.Format("EXEC layhd {0}",maban);
            return DB.getData(sql);
        }
    }
    
}
