using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANHSACHMONHOC
{
    class monhoc
    {
        private string maMon;

        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }
        private string tenMon;

        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }
        private DateTime ngayDangKy;

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

        public monhoc()
        {

        }

        public monhoc(string maMon, string tenMon, DateTime ngayDangKy, int soTinChi)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
            this.ngayDangKy = ngayDangKy;
            this.soTinChi = soTinChi;
        }

        //public string MaMon { get return maMon; set => maMon = value; }
        //public string TenMon { get return tenMon; set => tenMon = value; }
        //public DateTime NgayDangKy { get return ngayDangKy; set => ngayDangKy = value; }
        //public int SoTinChi { get return soTinChi; set => soTinChi = value; }
    }
}

