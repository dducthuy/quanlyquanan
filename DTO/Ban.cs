using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban
    {
        public int MaBan { get; set; }
        public string TrangThai { get; set; }
        public string Tenban { get;set; }


        public Ban(DataRow row) 
        {
            this.MaBan = (int)row["MaBan"];
            this.TrangThai = row["TrangThai"].ToString();

            this.Tenban = row["TenBan"].ToString() ;
            
        }
        public Ban() { }
    }
}
