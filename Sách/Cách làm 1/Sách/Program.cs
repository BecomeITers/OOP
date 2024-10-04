using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sách
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sach: ");
            int number = int.Parse(Console.ReadLine());
            Book[] sach = new Book[number];
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"Thong tin sach thu {i + 1}: ");
                sach[i] = new Book();
                sach[i].NhapSach();
            }
            Console.Write("Nhap ten sach tim kiem: ");
            string SearchBook = Console.ReadLine();
            Book FoundBook = new Book();
            foreach (var book in sach)
            {
                if (book.name == SearchBook)
                {
                    FoundBook = book;
                    break;
                }
            }
            if (FoundBook != null) 
            {
                Console.WriteLine("Ta gia da duoc tim thay:");
                FoundBook.InSach();
            }
            else
            {
                Console.WriteLine("Khong tim thay sach");
            }
            Console.ReadKey();
        }
    }
}
