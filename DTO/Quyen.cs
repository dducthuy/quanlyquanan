using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Quyen
    {
        public int MaQ { get; set; }
        public string TenQ { get; set; }
        public Quyen(int maQ, string tenQ)
        {
            this.MaQ = maQ;
            this.TenQ = tenQ;   
        }
        public Quyen(DataRow row)
        {
            this.MaQ = (int)row["MaQ"];

            this.TenQ= row["TenQ"].ToString();
        }
    }
}
