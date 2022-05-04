using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMonHoc_Dictionary_SV
{
    class Program
    {
        static public void showMenu()
        {
            Console.WriteLine("DANH SÁCH CÁC MÔN HỌC TRONG HK1 2019-2020!");
            Console.WriteLine("Nhập 0: Để thoát");
            Console.WriteLine("Nhập 1: Để nhập môn học mới");
            Console.WriteLine("Nhập 2: Để nhập môn học mới bằng số thứ tự");
            Console.WriteLine("Nhập 3: Để xoá môn học theo mã môn");
            Console.WriteLine("Nhập 4: Để xoá môn học theo số thứ tự");
            Console.WriteLine("Nhập 5: Để in thông tin theo mã môn học");
            Console.WriteLine("Nhập 6: Để in thông tin theo số thứ tự");
            Console.WriteLine("Nhập 7: Để in tất cả môn học");
            Console.WriteLine("Nhập 8: Để in ra tổng số môn học");
        }

        static public void toExit()
        {
            System.Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int option;
            string temp;
            int[] optionList = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            ListSubject list = new ListSubject();
            while (true)
            {
                showMenu();
                Console.Write("Nhập Tùy chọn: ");
                temp = Console.ReadLine();
                while (!int.TryParse(temp, out option) || !Array.Exists(optionList, elm => elm == option))
                {
                    Console.Write("ReEnter Option: ");
                    temp = Console.ReadLine();
                }
                switch (option)
                {
                    case 0:
                        toExit();
                        break;
                    case 1:
                        list.InputSubject();
                        break;
                    case 2:
                        list.InputSubjectWithIndex();
                        break;
                    case 3:
                        list.DeleteSubjectWithCode();
                        break;
                    case 4:
                        list.DeleteSubjectWithIndex();
                        break;
                    case 5:
                        list.PrintSubjectWithCode();
                        break;
                    case 6:
                        list.PrintSubjectWithIndex();
                        break;
                    case 7:
                        list.PrintSubjects();
                        break;
                    case 8:
                        list.CountSubjects();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
