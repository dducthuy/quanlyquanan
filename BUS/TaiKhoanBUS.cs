using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Diagnostics;


namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAL tk_dal = new TaiKhoanDAL();
        TaiKhoan taiKhoan = new TaiKhoan();

        public DataTable getData()
        {
            return tk_dal.getData();//dữ liệu từ dal đã đc chuyển vào Bus
        }
        public int kiemtramatrung(string ma)
        {
            return tk_dal.Check(ma);
        }

        public DataTable tim(string tk)

        {
            return tk_dal.TimKiem(tk);

        }

        public Tuple<string, string> checkLogin(string TenDangNhap, string MatKhau)
        {
            var result = tk_dal.checkLogin(TenDangNhap, MatKhau);

            // Kiểm tra kiểu dữ liệu của result
            if (result != null)
            {
     
                var tupleResult = (Tuple<string, string>)result;

                string MaQ = tupleResult.Item1;
                string MaTK = tupleResult.Item2;

                if (MaQ == "admin")
                {
                    return Tuple.Create("Đăng nhập thành công!: Quyền:"+MaQ,MaTK);
                }
                else
                {
                    return Tuple.Create("Đăng nhập thành công!: Quyền: User"+MaQ,MaTK);
                }
            }
            else
            {
                throw new Exception("sai tài Khoản hoặc Mật khẩu!");
            }
        }

        public bool Them(string TenDangNhap, string MatKhau, string MaTK, string MaQ)
        {
            if (string.IsNullOrEmpty(TenDangNhap) || string.IsNullOrEmpty(MatKhau) || string.IsNullOrEmpty(MaQ))
            {
                throw new Exception("Thông tin không hợp lệ!");
            }
            if (MatKhau.Length < 6)
            {
                throw new Exception("Mật khẩu không đủ mạnh.");
            }
            int checkid = tk_dal.Check(MaTK);
            int checkname = tk_dal.checkName(TenDangNhap);


            if (checkid >= 1)
            {
                throw new Exception("Mã tài Khoản đã tồn tại!");

            }
            else if (checkname >= 1)
            {
                throw new Exception("Tên tài khoản đã tồn tại!");

            }
            // Tạo một đối tượng TaiKhoan từ các tham số đầu vào
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TK = TenDangNhap;
            taiKhoan.mk = MatKhau;
            taiKhoan.MaTK = MaTK;
            taiKhoan.MaQ = MaQ;

            // Gọi phương thức Them từ lớp DAL để thêm tài khoản vào cơ sở dữ liệu
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.Them(taiKhoan);
        }
        public bool Sua(string Matk, string TK, string MK, string MaQ)
        {
            if (string.IsNullOrEmpty(TK) || string.IsNullOrEmpty(MK) || string.IsNullOrEmpty(MaQ))
            {
                throw new Exception("Thông tin không hợp lệ!");
            }
            if (MK.Length < 6)
            {
                throw new Exception("Mật khẩu không đủ mạnh.");
            }
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TK = TK;
            taiKhoan.mk = MK;
            taiKhoan.MaTK = Matk;
            taiKhoan.MaQ = MaQ;
            tk_dal.Sua(taiKhoan);
            return true;


        }
        public string Xoa(string Matk, string TK, string MK, string MaQ)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TK = TK;
            taiKhoan.mk = MK;
            taiKhoan.MaTK = Matk;
            taiKhoan.MaQ = MaQ;
            bool check = tk_dal.Xoa(taiKhoan);
            if (check == false) 
            {
                throw new Exception("xóa Thất bại!");

            }
            else
            {
                return "xóa Thành công";
            }
        
            
            
        }
     



    }
}
