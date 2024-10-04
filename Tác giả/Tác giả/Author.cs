using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tác_giả
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
                if (!value.Contains('@'))
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
                if (value != 'm' && value != 'f' && value != 'u')
                {
                    throw new AggregateException("Invalid gender");
                }
                _gender = value;
            }
        }
        public Author()
        {
            _name = null;
            _email = null;
            _gender = 'u';
        }
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        
        public void Nhap()
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap email: ");
            email = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string input = Console.ReadLine();
            if (input.Length == 1)
            {
                gender = input[0];  // Chuyển chuỗi thành ký tự
            }
        } 
        public void In()
        {
            Console.WriteLine($"Name: {name}, Email: {email}, Gender: {gender}");
        }
    }
}
