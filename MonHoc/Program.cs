using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMonHoc_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSach_Dictionary danhsach = new DanhSach_Dictionary();
            danhsach.nhap();
            danhsach.xuat();
            danhsach.xoa();
            danhsach.them();
            danhsach.dem();
            Console.ReadLine();
        }
    }
}
