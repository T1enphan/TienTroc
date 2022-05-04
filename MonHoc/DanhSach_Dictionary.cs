using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMonHoc_Dictionary
{
    class DanhSach_Dictionary
    {
        

        //public void KiemtraNhap()
        //{
        //    while(true)
        //    {
        //        MonHoc mh = new MonHoc();
        //        try
        //        {                   
        //            mh.Nhap();
        //            danhsach.Add(mh.MaMon, mh);
        //            break;
        //        }
        //       catch
        //        {
        //            Console.WriteLine("Nhập trùng mã");
        //        }
        //    }
        //}
        Dictionary<string, MonHoc> danhsach = new Dictionary<string, MonHoc>();
        public void nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.Write("Nhập phím bất kì để thêm môn học, 0 để thoát ");
                string n = Console.ReadLine();
                if (n != "0")
                {
                    MonHoc mh = new MonHoc();
                    mh.Nhap();
                    danhsach.Add(mh.MaMon, mh);
                    //KiemtraNhap();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        public void xuat()
        {
            foreach (MonHoc item in danhsach.Values)
            {
                item.Xuat();   
            }
            Console.WriteLine();
        }
        public void xoa()
        {
            Console.Write("----------Nhập mã môn cần xóa ----------------- "); string maMonXoa = Console.ReadLine();
            if (danhsach.ContainsKey(maMonXoa)) 
            {
                danhsach.Remove(maMonXoa); 
                Console.WriteLine("************* Danh sách sau khi xóa *************");
                xuat();
            }
            else Console.WriteLine("Không tìm thấy {0}\n", maMonXoa);
        }
        public void them()
        {
            Console.WriteLine("************************************ Nhaapj mon hoc can them *************************");
            MonHoc MH = new MonHoc();
            MH.Nhap();
            danhsach.Add(MH.MaMon, MH);
            Console.WriteLine("************************************ Danh sach sau khi them *************************");
            foreach (MonHoc item in danhsach.Values)
            {
                item.Xuat();
            }
            //Console.Write("Nhập vị trí cần thêm : "); int n = int.Parse(Console.ReadLine());
            //List<KeyValuePair<string, MonHoc>> listT = danhsach.ToList();          
            //if (n >= 0 && n <= listT.Count)
            //{
            //    MonHoc mh = new MonHoc();
            //    mh.Nhap();
            //    listT.Insert(n, new KeyValuePair<string, MonHoc>(mh.MaMon, mh));
            //    danhsach = listT.ToDictionary(x => x.Key, x => x.Value);
            //    xuat();
            //}
            //else
            //{
            //    Console.WriteLine("Vị trí không hợp lệ");
            //}
            //Console.WriteLine();
        }
        public void dem()
        {
            Console.WriteLine("Tổng số môn : " + danhsach.Count);
        }
    }
}
