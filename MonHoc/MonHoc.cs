using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMonHoc_Dictionary
{
    class MonHoc
    {
        string maMon;

        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }

        string tenMon;

        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }
        DateTime ngayDangKy;

        public DateTime NgayDangKy
        {
            get { return ngayDangKy; }
            set { ngayDangKy = value; }
        }
        private int soTinChi;

        public int SoTinChi
        {
            get { return soTinChi; }
            set { soTinChi = value; }
        }
        public MonHoc() { }
        public MonHoc(string maMon, string TenMon, DateTime ngayDangKy, int SoTinChi)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.NgayDangKy = ngayDangKy;
            this.SoTinChi = soTinChi; 
        }

        public void Nhap()
        {
            Console.WriteLine("-------- Nhập Thông tin môn học----------------");
            Console.Write("Nhập mã môn học : "); MaMon = Console.ReadLine(); 
            Console.Write("Nhập tên môn học : "); TenMon = Console.ReadLine();
            Console.Write("Nhập ngày đăng ký : "); NgayDangKy = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập số tín chỉ : "); SoTinChi = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("******************************* Xuất Thông tin môn học có mã môn là {0}****************", MaMon);
            Console.WriteLine("Mã môn học là: {0}", MaMon);
            Console.WriteLine("Tên môn học là: " + TenMon);
            Console.WriteLine("Ngày đăng ký là: {0}", NgayDangKy);
            Console.WriteLine("Số tín chỉ là: {0}", SoTinChi);
        }
    }
}

