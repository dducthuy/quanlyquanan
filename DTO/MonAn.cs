using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn
    {
        public MonAn() { }
        public MonAn(string MaMOn,string TenMon,float Gia,string MaDM,int cell) 
        
        {
            this.MaDM = MaDM;
            this.MaMon = MaMOn;
            this.TenMon = TenMon;
            this.Gia = Gia;
            this.Cell = cell;

        
        }    

        public MonAn(DataRow row)
        {
            this.MaDM = row["MaDM"].ToString();
            this.MaMon = row["MaMon"].ToString();
            this.TenMon = row["TenMon"].ToString();
            this.Gia = row["Gia"] != DBNull.Value ? Convert.ToSingle(row["Gia"]) : (float?)null;

            this.Cell = row["Cell"] != DBNull.Value ? Convert.ToInt32(row["Cell"]) : (int?)null;
           
            
        }
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public float? Gia { get; set; }
        public string MaDM { get; set; }
        public int? Cell {  get; set; }
    }
}
