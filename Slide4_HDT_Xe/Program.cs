using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide4_HDT_Xe
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSach danhsach = new DanhSach();
            danhsach.Nhap();
            danhsach.Xuat();
            danhsach.Them();
            Console.ReadLine();
        }
    }
}
