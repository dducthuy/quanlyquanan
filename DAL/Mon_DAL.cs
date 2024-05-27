using DAL.InterFace;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class MonAn_DAL : InQuanLy
    {
        DataBase_DAL DBConnect = new DataBase_DAL();

        public bool Them(object obj)
        {
            MonAn monAn = (MonAn)obj;
            string sql = string.Format("INSERT INTO MonAn VALUES('{0}', N'{1}',' {2}', '{3}', '{4}')", monAn.MaMon, monAn.TenMon, monAn.Gia, monAn.MaDM, monAn.Cell);
            DBConnect.thucthisql(sql);
            return true;
        }



        public void Sua(object obj)
        {
            MonAn monAn = (MonAn)obj;
            string sql = string.Format("UPDATE MonAn SET TenMon = N'{0}', Gia = '{1}', MaDM = '{2}', Cell = '{3}' WHERE MaMon = '{4}'", monAn.TenMon, monAn.Gia, monAn.MaDM, monAn.Cell, monAn.MaMon);
            DBConnect.thucthisql(sql);
        }

        public bool Xoa(object obj)
        {
            MonAn monAn = (MonAn)obj;
            string queryDelete = string.Format("DELETE FROM MonAn WHERE MaMon = '{0}'", monAn.MaMon);
            DBConnect.thucthisql(queryDelete);
            return true;
        }

        public DataTable TimKiem(string Key)
        {
            string querySelect = "SELECT * FROM MonAn WHERE TenMon LIKE N'%" + Key.Trim() + "%'";
            return DBConnect.getData(querySelect);
        }

        public DataTable getData()
        {
            string sql = "select \r\nma.MaMon,\r\nma.TenMon,\r\nma.Gia,\r\ndm.TenDM,\r\nma.Cell\r\n\r\nfrom MonAn as ma  inner join DanhMucMon as dm on ma.MaDM = dm.MaDM order by cell desc;";
            return DBConnect.getData(sql);
        }

        public int Check(string ma)
        {
            string sql = "SELECT COUNT(*) FROM MonAn WHERE MaMon='" + ma.Trim() + "'";
            return DBConnect.CheckID(ma, sql);
        }

        public int CheckMaDM(string ma)
        {
            string sql = "SELECT COUNT(*) FROM DanhMuc WHERE MaDM='" + ma.Trim() + "'";
            return DBConnect.CheckID(ma, sql);
        }
        // ds mon từ MaDM
        public List<MonAn> laydsmon(string MaDM)
        {
            List<MonAn> ds = new List<MonAn>();
            string sql = string.Format("select * from MonAn where MaDM= '{0}'",MaDM);
            DataTable dt = DBConnect.getData(sql);
            foreach (DataRow dr in dt.Rows)
            {
                MonAn mon =new MonAn(dr);
                ds.Add(mon);    

            }
            return ds;
        }
        ///exec Top5spngay '{0}'
          public DataTable spbanchay(string ngay)
        {
            string sql = string.Format("exec Top5spngay '{0}'", ngay);
            return DBConnect.getData(sql);
        }
}
}
