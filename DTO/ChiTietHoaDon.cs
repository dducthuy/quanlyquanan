using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class ChiTietHoaDon
    {
        public int MaChiTietHD { get; set; }
        public int MaHD { get; set; }
        public string MaMon { get; set; }
        public int SoLuong { get; set; }
        public ChiTietHoaDon() { }
        public ChiTietHoaDon(DataRow row) 
        {
            this.MaChiTietHD = (int)row["MaChiTietHD"];
            this.MaHD = (int)row["MaHD"];
            this.MaMon = row["MaMon"].ToString();
            this.SoLuong = (int)row["SoLuong"];
        }



    }

}
