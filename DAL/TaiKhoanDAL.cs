using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.InterFace;
using System.Data;
using System.Collections;
using System.Runtime.Remoting.Contexts;


namespace DAL
{
    public class TaiKhoanDAL : InQuanLy
    {
        DataBase_DAL DBConnect = new DataBase_DAL();

        public bool Them(object obj)
        {
            TaiKhoan TK = (TaiKhoan)obj;
            string sql = string.Format("Insert into TaiKhoan values('{0}','{1}', '{2}', '{3}')",TK.MaTK ,TK.TK ,TK.mk , TK.MaQ);
            DBConnect.thucthisql(sql);
            return true;

        }

        public void Sua(object obj)
        {
            TaiKhoan TK = (TaiKhoan)obj;
            string  sql = string.Format("UPDATE TaiKhoan SET TK = '{0}', MK = '{1}', MaQ = '{2}' WHERE MaTK = '{3}'", TK.TK, TK.mk, TK.MaQ, TK.MaTK);
            DBConnect.thucthisql(sql);

        }

        public bool Xoa(object obj)
        {
            TaiKhoan TK = (TaiKhoan)obj;
            string queryDelete = string.Format("DELETE FROM TaiKhoan WHERE MaTK = '{0}'", TK.MaTK);
            DBConnect.thucthisql(queryDelete);
            return true;

        }

        public DataTable TimKiem(string Key)
        {
            string querySelect = "SELECT * FROM TaiKhoan WHERE TK LIKE '%" + Key.Trim() + "%'";
            return DBConnect.getData(querySelect);
        }

        public DataTable getData()
        {
            string sql = "Select * from Taikhoan";
            return DBConnect.getData(sql);
        }
        public int Check(string ma)
        {
            string sql = "Select count(*) from TaiKhoan where MaTK='" + ma.Trim() + "'";
            return DBConnect.CheckID(ma, sql);
        }
        public int checkName(string TK) 
        { 
            string sql = "Select count(*) from TaiKhoan where TK='" + TK.Trim() + "'";
            return DBConnect.CheckID(TK, sql);
        }

       
        public Tuple<string, string> checkLogin(string TenDangNhap, string MatKhau)
        {
            string query = $"SELECT * FROM TaiKhoan WHERE TK = N'{TenDangNhap}' AND mk = N'{MatKhau}'";
            DataTable table = DBConnect.getData(query);
            if (table.Rows.Count < 1)
            {
                return null; // Trả về null nếu không tìm thấy tài khoản
            }
            else
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                foreach (DataRow row in table.Rows)
                {
                    taiKhoan.TK = row["TK"].ToString();
                    taiKhoan.mk = row["mk"].ToString();
                    taiKhoan.MaQ = row["MaQ"].ToString();
                    taiKhoan.MaTK = row["MaTK"].ToString();
                }
                return Tuple.Create(taiKhoan.MaQ, taiKhoan.MaTK); // Trả về một cặp giá trị (MaQ, MaTK)
            }
        }
       
 
    }
}
