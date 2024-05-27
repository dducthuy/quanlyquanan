using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class MonAn_BUS
    {
        MonAn_DAL monAnDAL = new MonAn_DAL();

        public bool ThemMonAn(MonAn monAn)
        {
            if (string.IsNullOrEmpty(monAn.TenMon) || monAn.Gia <= 0)

            {
                throw new AggregateException("Thông tin không hợp lệ!");
            }
        
                int checkMaMon = monAnDAL.Check(monAn.MaMon);
            if (checkMaMon >= 1)
            {
                throw new AggregateException("Mã món đã tồn tại!");
            }

            return monAnDAL.Them(monAn);
        }

        public DataTable LayDuLieu()
        {
            return monAnDAL.getData();
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return monAnDAL.TimKiem(tuKhoa);
        }

        public bool SuaMonAn(MonAn monAn)
        {
            if (string.IsNullOrEmpty(monAn.TenMon) || monAn.Gia == null)
            {
                throw new AggregateException("Thông tin không hợp lệ!");
            }


            monAnDAL.Sua(monAn);
            return true;
        }

        public string XoaMonAn(MonAn monAn)
        {
           

            bool check = monAnDAL.Xoa(monAn);
            if (!check)
            {
                throw new AggregateException("Xóa Thất bại");
            }
            else
            {
                return "Xóa Thành công";
            }
        }
        public DataTable spbanchay(string ngay)
        {
            return monAnDAL.spbanchay(ngay);
        }
    }
}