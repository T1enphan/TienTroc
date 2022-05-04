using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6TrenLop_Repair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key;
            Danhsach danhsach = new Danhsach();
            do
            {
                Console.Write("\n-----Menu-----\n");
                Console.Write("1: Them xe\n");
                Console.Write("2: Xoa xe\n");
                Console.Write("3: Chen xe\n");
                Console.Write("4: Xuat xe\n");
                Console.Write("Nhap lua chon : ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        danhsach.NhapXe();
                        break;
                    case 2:
                        danhsach.XoaXe();
                        break;
                    case 3:
                        danhsach.ChenXe();
                        break;
                    case 4:
                        danhsach.XuatXe();
                        break;
                }
            } while (key != 0);
        }
    }
}

