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
    namespace BUS
    {
        public class Ban_BUS
        {
               Ban_DAL banDAL = new Ban_DAL();

            public bool ThemBan(Ban ban)
            {
                if (string.IsNullOrEmpty(ban.Tenban))
                {
                    throw new AggregateException("Tên bàn không được để trống!");
                }


                int check = banDAL.Check(ban.Tenban);
                if (check != 0)
                {
                    throw new AggregateException("Tên bàn đã tồn tại!");
                }


                return banDAL.Them(ban);
            }

            public DataTable GetData()
            {
                return banDAL.getData();
            }

            public DataTable TimKiem(string tenBan)
            {
                return banDAL.TimKiem(tenBan);
            }

            public bool Sua(Ban ban)
            {
                
         
                    banDAL.Sua(ban);
                    return true;
                
               
            }

            public string Xoa(Ban ban)
            {
                bool check = banDAL.Xoa(ban);
                return "xóa Thành công";

               
                 
            }
            public void chuyenban(int maban, int mabandi)
            {
                
               banDAL.Chuyenban(maban, mabandi);
           
            }
            public List<Ban> loadBan()
            {
               return banDAL.loadBan();
            }
            public int ckeckbanthoat()
            {
                return banDAL.ckeckbanthoat();
            }
        }
    }
}
