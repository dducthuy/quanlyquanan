using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMuc
    {


        public string MaDM { get; set; }
        public string TenDM { get; set; }
        public DanhMuc() { }
        public DanhMuc(string MaDM, string TenDM) 
        {
        this.MaDM = MaDM;
            this.TenDM = TenDM;
        }
        public DanhMuc(DataRow row)
        {
            this.MaDM = row["MaDM"].ToString();
            this.TenDM = row["TenDM"].ToString();
        }
    }
}
