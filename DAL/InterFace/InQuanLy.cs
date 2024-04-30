using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.InterFace
{
    public interface InQuanLy
    {
        bool Them(object obj);
        void Sua(object obj);
        bool Xoa(object obj);

        DataTable TimKiem(string Key);   

    }
}
