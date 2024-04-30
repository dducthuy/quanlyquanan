using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    internal class HoaDon_DAL
    {
        HoaDon_DAL HD_Dal = new HoaDon_DAL();   
        public void NhapHD(int MaBan, string MaKH, string MaNV)
        {
             HD_Dal.NhapHD(MaBan,MaNV,MaNV);
          
        }
    }
}
