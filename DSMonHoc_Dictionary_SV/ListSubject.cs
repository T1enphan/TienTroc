using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMonHoc_Dictionary_SV
{
    class ListSubject
    {
        private Dictionary<int, Subject> ManagementSubject;
        private static string COLS_NAME = String.Format("|{0,10}|{1,20}|{2,20}|{3,30}|{4,20}|", "STT", "Mã môn học", "Tên môn học", "Ngày đăng ký", "Số tín chỉ");

        public ListSubject()
        {
            ManagementSubject = new Dictionary<int, Subject>();
        }

        public Dictionary<int, Subject> GetList()
        {
            return ManagementSubject;
        }

        public void InputSubjectWithIndex()
        {
            int index;
            Console.Write("Nhập số thứ tự: ");
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.Write("Đâu vào không hợp lệ. Nhập số thứ tự: ");
            }
            if (ManagementSubject.ContainsKey(index))
            {
                Console.WriteLine("LỖI: CÓ MÔN HỌC {0} TỒN TẠI Ở VỊ TRÍ NÀY!", ManagementSubject[index].SubjectCode);
            }

            Subject newSubject = new Subject();
            newSubject.InputSubject();
            ManagementSubject.Add(index, newSubject);
        }

        public void InputSubject()
        {
            int index = 0;
            Subject newSubject = new Subject();
            newSubject.InputSubject();
            if (ManagementSubject.Count == 0)
            {
                index = 1;
            }
            else
            {
                foreach (KeyValuePair<int, Subject> entry in ManagementSubject)
                {
                    if (entry.Key > index)
                    {
                        index = entry.Key;
                    }
                }
                index++;
            }
            ManagementSubject.Add(index, newSubject);
        }

        public void DeleteSubjectWithCode()
        {
            bool deleted = false;
            Console.Write("Nhập mã môn học muốn xóa: ");
            string subjectCode = Console.ReadLine();
            foreach (KeyValuePair<int, Subject> entry in ManagementSubject)
            {
                if (entry.Value.SubjectCode == subjectCode)
                {
                    ManagementSubject.Remove(entry.Key);
                    deleted = true;
                }
            }
            if (!deleted)
            {
                Console.WriteLine("LỖI: KHÔNG TỒN TẠI MÔN HỌC {0}!", subjectCode);
            }
            else
            {
                Console.WriteLine("XOÁ: MÔN HỌC {0} THÀNH CÔNG!", subjectCode);
            }
        }

        public void DeleteSubjectWithIndex()
        {
            Console.Write("Nhập số thứ tự cần xoá: ");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.Write("Đâu vào không hợp lệ. Nhập số thứ tự: ");
            }
            if (!ManagementSubject.ContainsKey(index))
            {
                Console.WriteLine("LỖI: KHÔNG TỒN TẠI MÔN HỌC Ở VỊ TRÍ {0} NÀY!", index);
            }
            else
            {
                string subjectCode = ManagementSubject[index].SubjectCode;
                ManagementSubject.Remove(index);
                Console.WriteLine("XOÁ: STT {0} CÓ MÃ MÔN HỌC {1} THÀNH CÔNG!", index, subjectCode);
            }
        }

        public void PrintSubjects()
        {
            Console.WriteLine(COLS_NAME);
            var sort = new SortedDictionary<int, Subject>(ManagementSubject);
            foreach (KeyValuePair<int, Subject> entry in sort)
            {
                Console.WriteLine(entry.Value.OutputPlusIndex(entry.Key));
            }
        }

        public void PrintSubjectWithCode()
        {
            bool finded = false;
            Console.Write("Nhập mã môn học muốn tìm: ");
            string subjectCode = Console.ReadLine();
            foreach (KeyValuePair<int, Subject> entry in ManagementSubject)
            {
                if (entry.Value.SubjectCode == subjectCode)
                {
                    Console.WriteLine(COLS_NAME);
                    Console.WriteLine(entry.Value.OutputPlusIndex(entry.Key));
                }
            }
            if (!finded)
            {
                Console.WriteLine("LỖI: KHÔNG TỒN TẠI MÃ MÔN HỌC {0}!", subjectCode);
            }
        }

        public void PrintSubjectWithIndex()
        {
            Console.Write("Nhập số thứ tự cần in: ");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.Write("Đâu vào không hợp lệ. Nhập số thứ tự: ");
            }
            if (ManagementSubject.ContainsKey(index))
            {
                Console.WriteLine(COLS_NAME);
                Console.WriteLine(ManagementSubject[index].OutputPlusIndex(index));
            }
            else
            {
                Console.WriteLine("LỖI: KHÔNG CÓ MÔN HỌC {0} TỒN TẠI Ở VỊ TRÍ NÀY!", index);
            }
        }

        public void CountSubjects()
        {
            Console.WriteLine("HIỆN TẠI CÓ {0} MÔN HỌC", ManagementSubject.Count);
        }
    }
}
