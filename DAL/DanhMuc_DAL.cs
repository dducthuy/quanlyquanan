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
        DataBase_DAL DB = new DataBase_DAL();   

        public List <DanhMuc> Laydsdm()
        {
            List<DanhMuc> ds =new List<DanhMuc>();
            string sql = "SELECT MaDM, TenDM FROM DanhMucMon";
            DataTable dt = DB.getData(sql);
            foreach(DataRow dr in dt.Rows)
            {
                DanhMuc Dm =new DanhMuc(dr);
                ds.Add(Dm);

            }
            return ds;
        }
    }
}
