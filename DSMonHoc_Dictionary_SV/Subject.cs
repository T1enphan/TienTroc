using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DSMonHoc_Dictionary_SV
{
    public class Subject
    {
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int CreditNumber { get; set; }

        static private string ToDigitsOnly(string input)
        {
            Regex digitsOnly = new Regex(@"[^\d]");
            return digitsOnly.Replace(input, "");
        }

        public void InputSubject()
        {
            Console.Write("Nhập mã môn học: ");
            string subjectCode = Console.ReadLine();
            Console.Write("Nhập tên môn học: ");
            string subjectName = Console.ReadLine();
            string strRegistrationDate;
            DateTime registrationDate;
            while (true)
            {
                Console.Write("Nhập Ngày đăng ký (dd/MM/yyyy): ");
                strRegistrationDate = Console.ReadLine();
                try
                {
                    string[] dateString = strRegistrationDate.Split('/');
                    int Year = Convert.ToInt32(ToDigitsOnly(dateString[2]));
                    int Month = Convert.ToInt32(ToDigitsOnly(dateString[1]));
                    int Day = Convert.ToInt32(ToDigitsOnly(dateString[0]));
                    registrationDate = new DateTime(Year, Month, Day, 00, 00, 00);
                    break;
                }
                catch
                {
                    Console.Write("Đâu vào không hợp lệ. Nhập Ngày đăng ký(dd/MM/yyyy): ");
                }
            }
            Console.Write("Nhập số tín chỉ: ");
            int creditNumber;
            while (!int.TryParse(Console.ReadLine(), out creditNumber))
            {
                Console.Write("Đâu vào không hợp, Nhập số tín chỉ:  ");
            }
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            RegistrationDate = registrationDate;
            CreditNumber = creditNumber;
            Console.WriteLine("Môn học: nhập thành công!");
        }

        public string OutputSubject()
        {
            return String.Format("|{0,20}|{1,20}|{2,30}|{3,20}|", SubjectCode, SubjectName, RegistrationDate.ToString("dd/MM/yyyy"), CreditNumber);
        }

        public string OutputPlusIndex(int index)
        {
            return String.Format("|{0,10}|{1,20}|{2,20}|{3,30}|{4,20}|", index, SubjectCode, SubjectName, RegistrationDate.ToString("dd/MM/yyyy"), CreditNumber);
        }
    }
}
