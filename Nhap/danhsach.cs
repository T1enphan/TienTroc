using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace BT6TrenLop_Repair
{
    internal class Danhsach
    {
        OrderedDictionary od = new OrderedDictionary();
        public void NhapXe()
        {
            Xe Car = new Xe();
            Car.Nhap();
            od.Add(Car.BienSo, Car);
        }
        public void XuatXe()
        {
            if (od.Count == 0) Console.WriteLine("\n***************Danh sach trong***************");
            if (od.Count > 0)
            {
                Console.WriteLine("**************In danh sach xe**************");
                foreach (Xe item in od.Values)
                {
                    item.Xuat();
                }
            }
        }
        public void XoaXe()
        {
            Console.WriteLine("**************Nhap bien so can xoa**************");
            string biensoXoa = Console.ReadLine();
            if (od.Contains(biensoXoa))
            {
                Console.WriteLine("**************Co bien so can xoa**************");
                od.Remove(biensoXoa);
            }
            else Console.WriteLine("**************Khong co bien so can xoa**************");
        }

        public void ChenXe()
        {
            Console.WriteLine("**************Nhap vi tri can chen**************");
            int x;
            do
            {
                Console.WriteLine("\nNhap x trong khoang xe vua co bat dau tu 0 den {0}", od.Count);
                x = int.Parse(Console.ReadLine());
                if (od.Count >= x && od.Count >= 0 && x >= 0)
                {
                    break;
                }
            } while (true);
            Console.WriteLine("\n**************Nhap thong tin xe can chen**************");
            Xe Car = new Xe();
            do
            {
                Console.WriteLine("Nhap bien so xe can chen de kiem tra");
                string bienso = Console.ReadLine();
                if (!od.Contains(bienso))
                {
                    Car.Nhap();
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai vi trung bien so xe");
                }
            } while (true);
            od.Insert(x, Car.BienSo, Car); 
        }
    }
}

