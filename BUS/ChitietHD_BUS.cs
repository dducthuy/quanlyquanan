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
    public class ChitietHD_BUS
    {
        ChiTietHD_DAL ct = new ChiTietHD_DAL();
        public void NhapCT(int MaHD, string MaMon, int soluong)
        {
             ct.NhapCT(MaHD,MaMon,soluong);
        }
        public int ckeckmonhoadon(int mahd, string mamon)
        {
            return ct.ckeckmonhoadon(mahd, mamon);
        }
        public List<ChiTietHoaDon> DschitietHD(int MaHD)
        {
            return ct.DschitietHD(MaHD);
        }
        public void nhapCT(int MaHD, string MaMon, int soluong)
        {
            ct.NhapCT(MaHD, MaMon, soluong);    
        }
        public DataTable layhd(int maban)
        {
            return ct.layhd(maban); 
        }
        public DataTable layhd_tk(int MaHD)
        {
            return ct.layhdtk(MaHD);
        }
    }
}
