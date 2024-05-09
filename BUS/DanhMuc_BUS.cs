using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class DanhMuc_BUS
    {
        DanhMuc_DAL danhMucDAL =new DanhMuc_DAL();
        public bool ThemDanhMuc(DanhMuc danhMuc)
        {
            if (string.IsNullOrEmpty(danhMuc.TenDM) && string.IsNullOrEmpty(danhMuc.MaDM))
            {
                throw new AggregateException("Thông tin không được để trống!");
            }

            int check = danhMucDAL.Check(danhMuc.TenDM);
            if (check != 0)
            {
                throw new AggregateException("Tên danh mục đã tồn tại!");
            }

            return danhMucDAL.Them(danhMuc);
        }

        public DataTable GetData()
        {
            return danhMucDAL.getData();
        }

        public DataTable TimKiem(string tenDanhMuc)
        {
            return danhMucDAL.TimKiem(tenDanhMuc);
        }

        public bool Sua(DanhMuc danhMuc)
        {
            if (string.IsNullOrEmpty(danhMuc.TenDM) || string.IsNullOrEmpty(danhMuc.MaDM.ToString()))
            {
                throw new AggregateException("Thông tin không hợp lệ!");
            }

            danhMucDAL.Sua(danhMuc);
            return true;
        }

        public string Xoa(DanhMuc danhMuc)
        {
            bool check = danhMucDAL.Xoa(danhMuc);
            if (!check)
            {
                throw new AggregateException("Xóa thất bại!");
            }
            else
            {
                return "Xóa thành công!";
            }
        }

    }
}
