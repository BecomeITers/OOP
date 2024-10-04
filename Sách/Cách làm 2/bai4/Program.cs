using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Console.Write("Nhap so luong sach: ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("Nhap ten sach : ");
                string sach = Console.ReadLine();
                Console.Write("Nhap ten tac gia : ");
                string tacgia = Console.ReadLine();
                Console.Write("Nhap email tac gia : ");
                string email = Console.ReadLine();
                Console.Write("Nhap gioi tinh tac gia : ");
                string gender = Console.ReadLine();
                Console.Write("Nhap gia ban sach : ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Nhap so luong sach: ");
                int qty = int.Parse(Console.ReadLine());

                Author author = new Author(tacgia, email, gender);
                books.Add(new Book(sach, author, price, qty));
            }

            Console.Write("Enter the name of the book you want to find: ");
            string searchName = Console.ReadLine();

            Book foundBook = books.Find(b => b.getName() == searchName);

            if (foundBook != null)
            {
                Console.WriteLine(foundBook.toString());
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
            Console.ReadKey();
        }
    }
}