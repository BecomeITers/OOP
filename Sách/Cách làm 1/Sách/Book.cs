using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sách
{
    internal class Book
    {
        private string _name;
        private Author _author;
        private double _price;
        private int _qty = 0;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Author author
        {
            get { return _author; }
            set { _author = value; }
        }
        public double price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int qty
        {
            get { return _qty; }
            set { _qty = value; }
        }
        public Book()
        {
            _name = " ";
            _price = 0;
        }
        public Book(string name, Author author, double price, int qty)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
        }
        Author tacgia = new Author();
        public void NhapSach()
        {
            Console.Write("Nhap ten sach: ");
            name = Console.ReadLine();
            tacgia.NhapTacGia();
            Console.Write("Nhap gia tien: ");
            price = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong ban: ");
            qty = int.Parse(Console.ReadLine());
        }
        public void InSach()
        {
            Console.WriteLine($"Ten sach: {name}");
            tacgia.InTacGia();
            Console.WriteLine($"Gia tien: {price}");
            Console.WriteLine($"So luong ban: {qty}");
        }
    }
}
