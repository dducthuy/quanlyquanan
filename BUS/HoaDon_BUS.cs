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
    public class HoaDon_BUS

    {
        

        HoaDon_DAL HD_Dal = new HoaDon_DAL();

        public int layMaHD(int MaBan)
        {
            return HD_Dal.layMaHD(MaBan);
        }

        public void ThemHD(int MaBan, string MaNV)
        {
            HD_Dal.ThemHD(MaBan, MaNV);
        }

        public int getMaxMaHD()
        {
            return HD_Dal.getMaxMaHD();
        }

        public void checkout(int MaHD, int MaBan)
        {
            HD_Dal.checkout(MaHD, MaBan);
        }

        public DataTable DTThangnam(int ngay, int nam)
        {
          return   HD_Dal.DTThangnam(ngay, nam);
        }

        public DataTable DTNgay(string ngay)
        {
          return  HD_Dal.DTNgay(ngay);
        }

    }
}
