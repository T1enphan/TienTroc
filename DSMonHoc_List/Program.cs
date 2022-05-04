using System;

namespace DANHSACHMONHOC
{
    class Program
    {
        static void Main(string[] args)
        {
            danhsach ds = new danhsach();
            ds.nhap();
            ds.xuat();
            ds.xoa();
            ds.them();
            ds.dem();
        }
    }
}
