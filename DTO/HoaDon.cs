using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public int? MaBan { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayThanhToan { get; set; } 
      
        public string MaNV { get; set; }
        public string TinhTrang { get; set; }
       
        public HoaDon() { }
        public HoaDon(DataRow row) 
        {
            this.MaHD = (int)row["MaHD"];
            this.NgayDat = (DateTime?)row["NgayTao"];
            var checkNTT = row["NgayThanhToan"];
            if (checkNTT.ToString() != "")
             this.NgayThanhToan = (DateTime?)checkNTT;
            
            
            this.MaBan = (int)row["MaBan"];
            this.TinhTrang = row["Tinhtrang"].ToString();
       
            
    
            this.MaNV = row["MaNV"].ToString();
        }



    }
}
