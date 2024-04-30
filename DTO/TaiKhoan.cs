using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public TaiKhoan() { }
        public TaiKhoan(DataRow row ) 
        
        {
            this.MaTK = row["MaTK"].ToString();
            this.TK = row["TK"].ToString();
           this. mk = row["mk"].ToString();
           this. MaQ = row["MaQ"].ToString();


        }
        public TaiKhoan(string name) { }
        public string MaTK { get; set; }
        public string TK { get; set; }
        public string mk { get; set; }
        public string MaQ { get; set; }
    }
}
