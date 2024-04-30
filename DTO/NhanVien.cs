using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string NgaySinh { get; set; }

        public string MaTK { get; set; }
        public NhanVien() { }
        public NhanVien(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.SDT = row["SDT"].ToString();
            this.NgaySinh = row["NgaySinh"].ToString();
            this.MaTK = row["MaTK"].ToString();
        }


    }
}
