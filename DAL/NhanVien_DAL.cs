using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.InterFace;
using DTO;
namespace DAL
{
    public class NhanVien_DAL : InQuanLy
    {

        DataBase_DAL DBConnect = new DataBase_DAL();


        public bool Them(object obj)
           {
                NhanVien nv = (NhanVien)obj;
            

           string sql = string.Format("INSERT INTO NhanVien VALUES( '{0}', N'{1}', '{2}', '{3}', '{4}')", nv.MaNV, nv.HoTen, nv.SDT,nv.NgaySinh, nv.MaTK);
               DBConnect.thucthisql(sql);
              return true;
           }
    

        public void Sua(object obj)
        {
            NhanVien nv = (NhanVien)obj;


            string sql = string.Format("UPDATE NhanVien SET HoTen = N'{0}', SDT = '{1}', NgaySinh = '{2}', MaTK = '{3}' WHERE MaNV = '{4}'", nv.HoTen, nv.SDT, nv.NgaySinh, nv.MaTK, nv.MaNV);
            DBConnect.thucthisql(sql);
        }


        public bool Xoa(object obj)
            {
                NhanVien nv = (NhanVien)obj;
                string queryDelete = string.Format("DELETE FROM NhanVien WHERE MaNV = '{0}'", nv.MaNV);
                DBConnect.thucthisql(queryDelete);
                return true;
            }

            public DataTable TimKiem(string Key)
            {
                string querySelect = "SELECT * FROM NhanVien WHERE HoTen LIKE '%" + Key.Trim() + "%'";
                return DBConnect.getData(querySelect);
            }

            public DataTable getData()
            {
                string sql = "SELECT * FROM NhanVien";
                return DBConnect.getData(sql);
            }

            public int Check(string ma)
            {
                string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV='" + ma.Trim() + "'";
                return DBConnect.CheckID(ma, sql);
            }
        public int CheckMa(string ma)
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE MaTK='" + ma.Trim() + "'";
            return DBConnect.CheckID(ma, sql);
        }
        public int checkMaTKNV(string ma)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaTK='" + ma.Trim() + "'";
            return DBConnect.CheckID(ma, sql);

        }
        public string layMaNV(string MaTK)
        {
            string sql = string.Format("select* from NhanVien where  MaTK ='{0}'", MaTK);
            DataTable dt = DBConnect.getData(sql);

            if (dt.Rows.Count > 0)
            {
                NhanVien nv = new NhanVien(dt.Rows[0]);
                return nv.MaNV;
            }

            return "null";
        }


    }
}
