using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Xml.Schema;
using System.Data;
namespace BUS
{
    public class NhanVien_BUS
    {
        NhanVien_DAL nvDAL = new NhanVien_DAL();
      //  NhanVien NV = new NhanVien();
        public bool ThemNV(NhanVien NV)
        {
            if (string.IsNullOrEmpty(NV.MaNV) || string.IsNullOrEmpty(NV.HoTen) || string.IsNullOrEmpty(NV.SDT) || NV.NgaySinh == null)
            {
                throw new AggregateException("Thông tin không hợp lệ!");
            }

            if (NV.SDT.Length <= 9 || !NV.SDT.All(char.IsDigit))
            {
                throw new AggregateException("Số điện thoại phải có 10 số!");
            }
            int checkma = nvDAL.checkMaTKNV(NV.MaTK);
            int checkid = nvDAL.Check(NV.MaNV);
            int check = nvDAL.CheckMa(NV.MaTK);
            if (checkid >= 1)
            {
                throw new AggregateException("Mã Nhân viên đã tồn tại!");
            }
            if (check < 1)
            {
                throw new AggregateException("Mã tài Khoản không tồn tại!");
            }
            if(checkma >= 1)
            {
                throw new AggregateException("Mã tài khoản  đã được liên kết với 1 nhân viên khác!");
            }
            return nvDAL.Them(NV);
        }

        public DataTable GetData()
        {
            return nvDAL.getData();

        }
        public DataTable tim(string tk)

        {
            return nvDAL.TimKiem(tk);

        }
        public bool Sua(NhanVien NV)
        {
            if (string.IsNullOrEmpty(NV.MaNV) || string.IsNullOrEmpty(NV.HoTen) || string.IsNullOrEmpty(NV.SDT) || NV.NgaySinh == null)
            {
                throw new AggregateException("Thông tin không hợp lệ!");
            }

            if (NV.SDT.Length <= 9 || !NV.SDT.All(char.IsDigit))
            {
                throw new AggregateException("Số điện thoại phải có 10 số!");
            }
            nvDAL.Sua(NV);
            return true;
        }
        public  string  xoa(NhanVien NV)
        {
            bool check = nvDAL.Xoa(NV);
           
            if (check ==  false )
            {
                throw new AggregateException("xóa Thành Thất bại");
            }
            else
            {
                return " Xóa Thành công";
            }
         
        }
        public string laymnv(string maTK)
        {
            return nvDAL.layMaNV(maTK);
        }
    }
}
