using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sách
{
    internal class Author
    {
        private string _name;
        private string _email;
        private char _gender;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Invalid @");
                }
                _email = value;
            }
        }
        public char gender
        {
            get { return _gender; }
            set
            {
                if(value != 'm' && value != 'f' && value != 'u')
                {
                    throw new ArgumentException("Invalid gender");
                }
                _gender = value;
            }
        }
        public Author()
        {
            _name = _email = null;
            _gender = 'u';
        }
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        public void NhapTacGia()
        {
            Console.Write("Nhap ten tac gia: ");
            name = Console.ReadLine();
            Console.Write("Nhap email: ");
            email = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string input = Console.ReadLine();
            if(input.Length == 1)
            {
                gender = input[0];
            }
        }
        public void InTacGia()
        {
            Console.WriteLine($"Ten: {name}, Email: {email}, Gioi tinh: {gender}");
        }
    }
}
