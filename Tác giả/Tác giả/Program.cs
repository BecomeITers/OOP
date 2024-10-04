using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tác_giả
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong tac gia: ");
            int number = int.Parse(Console.ReadLine());
            Author[] tacgia = new Author[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Thong tin tac gia thu {i + 1}: ");
                tacgia[i] = new Author();
                tacgia[i].Nhap();  
            }
            Console.Write("Nhap ten tac gia can tim kiem: ");
            string SearchName = Console.ReadLine();

            Author FoundName = new Author();
            foreach (var author in tacgia) // Vòng lặp for tìm kiếm nhanh
            {
                if (author.name.Equals(SearchName, StringComparison.OrdinalIgnoreCase)) // So sánh chuỗi ko phân biệt chữ hoa chữ thường
                { 
                    FoundName = author;
                    break;
                }
            }
            if (FoundName != null)
            {
                Console.WriteLine($"Tac gia da duoc tim thay:");
                FoundName.In();
            }
            else 
            {
                Console.WriteLine("Khong tim thay tac gia");
            }
            Console.ReadKey();
        }
    }
}
