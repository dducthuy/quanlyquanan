using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{

    public class MenuHD_DAL
    {

        DataBase_DAL DB = new DataBase_DAL();
        public List<MenuHD> laydsmenu(int MaBan)
        {
            string sql = "select m.TenMon,m.Gia,CT.SoLuong, CT.SoLuong*m.Gia as Tong  from MonAn as m,ChiTietHoaDon as CT , HoaDon as HD \r\nWhere m.MaMon = CT.MaMon and CT.MaHD =HD.MaHD and HD.TinhTrang = 1  and HD.MaBan =" + MaBan.ToString();

            List<MenuHD> menuHDs = new List<MenuHD>();
            DataTable dtMn = DB.getData(sql);
            foreach (DataRow dr in dtMn.Rows) 
            {  
                MenuHD menuHD = new MenuHD(dr);
                menuHDs.Add(menuHD);
            
            }


            return menuHDs;
        }
    }
}
