using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide4_HDT_Xe
{
    class Xe
    {
        string bienSo;                                                                      

        public string BienSo
        {
            get { return bienSo; }
            set { bienSo = value; }
        }
     
        private char tenXe;                       
        private DateTime ngayDangkiem;
        private int tieuChuanbang;

        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập biển số Xe: "); BienSo = Console.ReadLine();
            Console.Write("Nhập tên xe = KÝ TỰ: "); tenXe = char.Parse(Console.ReadLine()); 
            Console.Write("Ngày đăng kiểm: "); ngayDangkiem = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập tiêu chuẩn bằng: "); tieuChuanbang = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Biển số xe là: {0}", BienSo);
            Console.WriteLine("Tên xe = KÝ TỰ là: {0}", tenXe);
            Console.WriteLine("Ngày đăng kiểm là: {0}", ngayDangkiem);
            Console.WriteLine("Tiêu chuẩn bằng: {0}", tieuChuanbang);
        }
    }
}
