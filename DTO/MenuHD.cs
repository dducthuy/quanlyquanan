using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class MenuHD
    {
        public MenuHD() { }

        public string TenMon { get; set; }
        public float Gia { get; set; }

        public int SoLuong { get; set; }    
        public float? Tong { get; set; }

        public MenuHD(DataRow row) 
        {
            this.TenMon = row["TenMon"].ToString();
            this.Gia = (float)Convert.ToDouble(row["Gia"].ToString());
            this.SoLuong = (int)row["SoLuong"];
            this.Tong = (float)Convert.ToDouble(row["Tong"].ToString());




        }
    }
}
