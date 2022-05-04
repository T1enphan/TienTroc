using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6TrenLop_Repair
{
    internal class Xe
    {
        public string BienSo;
        public string TenXe;
        public DateTime NgayDangKiem;
        public int TrongTai;
        public int TieuChuanBang;

        //public string BienSo1
        //{
        //    get { return BienSo; }
        //    set { BienSo = value; }
        //}
        //public string TenXe1 { get => TenXe; set => TenXe = value; }
        //public DateTime NgayDangKiem1 { get => NgayDangKiem; set => NgayDangKiem = value; }
        //public int TrongTai1 { get => TrongTai; set => TrongTai = value; }
        //public int TieuChuanBang1 { get => TieuChuanBang; set => TieuChuanBang = value; }

        public void Nhap()
        {
            Console.Write("Nhap vao bien so xe: ");
            BienSo = Console.ReadLine();
            Console.Write("Nhap vao ten xe: ");
            TenXe = Console.ReadLine();
            Console.Write("Nhap vao ngay dang kiem xe: ");
            NgayDangKiem = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap vao trong tai xe: ");
            TrongTai = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao tieu chuan bang: ");
            TieuChuanBang = int.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine("_____________________________ Thông tin xe có bien so {0}________________________", BienSo);
            Console.WriteLine("Bien so xe la: " + BienSo);
            Console.WriteLine("Ten cua xe la: " + TenXe);
            Console.WriteLine(String.Format("Ngay dang kiem xe la: {0: dd/MM/yyyy}", NgayDangKiem));
            Console.WriteLine("Trong tai xe la: " + TrongTai);
            Console.WriteLine("Tieu chuan bang xe la: " + TieuChuanBang);
        }

        internal static IEnumerable<KeyValuePair<string, Xe>> OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
