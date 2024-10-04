using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class Author
    {
        private string name;
        private string email;
        private string gender;

        public Author(string name, string email, string gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender.ToLower() == "m" || gender.ToLower() == "f" || gender.ToLower() == "u" ? gender.ToLower() : throw new ArgumentException("invalid gender");
            // Dấu ? ở đây là toán tử 3 ngôi có nghĩa là nếu gender là "m", "f", "u" là true thì nó nó sẽ gán gender là 3 cái đó còn false nó sẽ in ra Invalid Gender
        }
        public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
            this.gender = "u";
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("invalid Email");
                }
                email = value;
            }
        }
        public string Gender
        {
            get { return gender; }
        }
        public string Name
        {
            get { return name; }
        }
        public override string ToString()
        {
            return $"Author [Name={Name}, Email={Email}, Gender={Gender}]";
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Gender: {Gender}, Email: {Email}");
        }
    }
}
