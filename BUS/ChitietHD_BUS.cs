using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    internal class ChitietHD_BUS
    {
        ChiTietHD_DAL ct = new ChiTietHD_DAL();
        public void NhapCT(int MaHD, string MaMon, int soluong)
        {
             ct.NhapCT(MaHD,MaMon,soluong);
        }
    }
}
