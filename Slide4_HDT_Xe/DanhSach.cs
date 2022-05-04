using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide4_HDT_Xe
{
    class DanhSach
    {
        Dictionary<string, Xe> danhsach;// =  new Dictionary<string, Xe>();
        //Xe xe = new Xe();
        Xe xe;
        public DanhSach()
        {
            danhsach = new Dictionary<string, Xe>();
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Nhập 0 để thoát, nhập phím bất kỳ để thêm");
                string nhap; nhap = Console.ReadLine();
                if (nhap == "0") break;
                else
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    //xe = new Xe();                //Nếu để dòng này thì xe ở hàm xuất (xuất ra thông tin 1 xe) là null, vì dòng này là ta khai báo lại đối tượng Xe
                    //xe.Xuat();    // Chỉ xuất ra thông tin 1 xe
                    xe = new Xe();
                    xe.Nhap();
                    danhsach.Add(xe.BienSo, xe);
                }
            }
        }
        public void Xuat()
        {
            //Xe xe = new Xe();   //Xuất sẽ ko ra giá trị vì xe ở đây là null, vì dòng này là ta khai báo lại đối tượng Xe
            //xe.Xuat();    // Chỉ xuất ra thông tin 1 xe
            Console.WriteLine();
            Console.WriteLine("\n-------Xuất danh sách xe-------");    // Xuất danh sách xe phải dùng hàm foreach
            foreach (Xe item in danhsach.Values)
                item.Xuat();
        }
        public void Them()
        {
            Console.WriteLine("----------------Nhập thông tin xe cần thêm");
                Xe xe = new Xe();
                xe.Nhap();
                danhsach.Add(xe.BienSo, xe);
            Console.WriteLine("\n-------Xuất danh sách xe-------");
            foreach (Xe item in danhsach.Values)
                item.Xuat();



            Console.WriteLine("---------------------------------Nhập vị trí cần thêm"); int viTri = int.Parse(Console.ReadLine());
            Dictionary<string, Xe> danhsach2 = new Dictionary<string, Xe>();
            Xe xe2 = new Xe();
            int i = 0;
            foreach(Xe item in danhsach.Values)
            {
                if(viTri == 0)
                {
                    xe2.Nhap();
                    danhsach2.Add(xe2.BienSo, xe2);
                    danhsach2.Add(item.BienSo, item);
                    viTri --;
                }
                else
                {
                    danhsach2.Add(item.BienSo, item);
                    i++;
                    if (i == viTri)
                    {
                        xe2.Nhap();
                        danhsach2.Add(xe2.BienSo, xe2);
                    }                   
                }
            }
            danhsach.Clear();
            danhsach = danhsach2;
            Console.WriteLine("----------------------------------Danh sách sau khi chèn tại vị trí {0}", viTri);
            foreach (Xe item in danhsach.Values)
                item.Xuat();
        }
    }
}
