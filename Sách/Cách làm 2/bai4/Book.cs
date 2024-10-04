using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Book
    {
        private string name;
        private Author author;
        private double price;
        private int qty = 0;

        public Book(string name, Author author, double price, int qty)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
        }

        public string getName()
        {
            return name;
        }

        public Author getAuthor()
        {
            return author;
        }

        public double getPrice()
        {
            return price;
        }

        public int getQty()
        {
            return qty;
        }

        public void SetQty(int qty)
        {
            this.qty = qty;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public string toString()
        {
            return $"Book [Name={getName()}, {getAuthor()}, Price={getPrice()}, Quantity={getQty()}]";
        }
    }
}
