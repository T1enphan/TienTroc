using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Tinh
{
    class Program
    {
        class SinhVien
        {
            public static string Ngaythi()
            {
                return "23/03/2017";
            }
        }
        static void Main(string[] args)
        {
            // SinhVien sv = new SinhVien();
            string ngaythi = SinhVien.Ngaythi();
            Console.WriteLine("Ngay thi cua sinh vien la {0}", ngaythi);
            Console.ReadLine();
        }
    }
}
