using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANHSACHMONHOC
{
    class danhsach
    {
        List<monhoc> listMonHoc = new List<monhoc>();
        private string ktrMa()
        {
            string x;
            while (true)
            {
                x = Console.ReadLine();
                var item = listMonHoc.SingleOrDefault(n => n.MaMon == x);
                if (item != null)
                {
                    Console.Write("Mã trùng nhập lại : ");
                }
                else break;
            }
            return x;
        }
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
                    monhoc mh = new monhoc();
                    Console.Write("Nhập mã môn học : "); mh.MaMon = ktrMa();
                    Console.Write("Nhập tên môn học : "); mh.TenMon = Console.ReadLine();
                    Console.Write("Nhập ngày đăng ký : "); mh.NgayDangKy = DateTime.Parse(Console.ReadLine());
                    Console.Write("Nhập số tín chỉ : "); mh.SoTinChi = int.Parse(Console.ReadLine());
                    listMonHoc.Add(mh);
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
            Console.WriteLine("----Danh sách môn học----");
            foreach (var item in listMonHoc)
            {
                Console.WriteLine("{0}--{1}--{2}--{3}", item.MaMon, item.TenMon, item.NgayDangKy, item.SoTinChi);

            }
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }
        public void xoa()
        {
            Console.Write("Nhập mã môn cần xóa : "); string n = Console.ReadLine();
            var item = listMonHoc.SingleOrDefault(x => x.MaMon == n);
            if (item != null)
            {
                listMonHoc.Remove(item);
                xuat();
            }
            else Console.WriteLine("Không tìm thấy {0}\n", n);
        }
        public void them()
        {
            Console.Write("Nhập vị trí cần thêm : "); int n = int.Parse(Console.ReadLine());
            if (n >= 0 && n <= listMonHoc.Count)
            {
                monhoc mh = new monhoc();
                Console.Write("Nhập mã môn học cần thêm : "); mh.MaMon = ktrMa();
                Console.Write("Nhập tên môn học : "); mh.TenMon = Console.ReadLine();
                Console.Write("Nhập ngày đăng ký : "); mh.NgayDangKy = DateTime.Parse(Console.ReadLine());
                Console.Write("Nhập số tín chỉ : "); mh.SoTinChi = int.Parse(Console.ReadLine());
                listMonHoc.Insert(n, mh);
                xuat();
            }
            else
            {
                Console.WriteLine("Vị trí không hợp lệ");
            }
            Console.WriteLine();
        }
        public void dem()
        {
            Console.WriteLine("Tổng số môn : " + listMonHoc.Count);
            Console.ReadLine();
        }
    }
}

