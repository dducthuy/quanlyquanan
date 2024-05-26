using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DanhMuc_DAL
    {
        DataBase_DAL DBConnect = new DataBase_DAL();   

        public List <DanhMuc> Laydsdm()
        {
            List<DanhMuc> ds =new List<DanhMuc>();
            string sql = "SELECT MaDM, TenDM FROM DanhMucMon";
            DataTable dt = DBConnect.getData(sql);
            foreach(DataRow dr in dt.Rows)
            {
                DanhMuc Dm =new DanhMuc(dr);
                ds.Add(Dm);

            }
            return ds;
        }
        public bool Them(object obj)
        {
            DanhMuc dm = (DanhMuc)obj;
            string sql = string.Format("INSERT INTO DanhMucMon (MaDM, TenDM) VALUES ('{0}', N'{1}')", dm.MaDM, dm.TenDM);
            DBConnect.thucthisql(sql);
            return true;
        }

        public void Sua(object obj)
        {
            DanhMuc dm = (DanhMuc)obj;
            string sql = string.Format("UPDATE DanhMucMon SET  TenDM = N'{0}' WHERE MaDM = '{1}'", dm.TenDM, dm.MaDM);
            DBConnect.thucthisql(sql);
        }


        public bool Xoa(object obj)
        {
            DanhMuc dm = (DanhMuc)obj;
            string queryDelete = string.Format("delete from DanhMucMon Where MaDM = '{0}'", dm.MaDM);
            DBConnect.thucthisql(queryDelete);
            return true;
        }

        public DataTable TimKiem(string Key)
        {
            string querySelect = "SELECT * FROM DanhMucMon WHERE TenDM LIKE N'%" + Key.Trim() + "%'";
            return DBConnect.getData(querySelect);
        }

        public DataTable getData()
        {
            string sql = "SELECT * FROM DanhMucMon";
            return DBConnect.getData(sql);
        }
        public int Check(string teban)
        {
            string sql = "SELECT COUNT(*) FROM DanhMucMon WHERE TenDM = '" + teban.Trim() + "'";
            return DBConnect.CheckID(teban, sql);
        }
        public int Checkid(string teban)
        {
            string sql = "SELECT COUNT(*) FROM DanhMucMon WHERE MaDM = '" + teban.Trim() + "'";
            return DBConnect.CheckID(teban, sql);
        }

    }
}
