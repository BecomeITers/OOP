using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Nhap so luong o to: ");
            number = int.Parse(Console.ReadLine());

            OTO[] oto = new OTO[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"O to thu {i + 1}: ");
                oto[i] = new OTO();
                oto[i].Nhap();
            }

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"Danh sach o to thu {i + 1}: ");
                oto[i].In();
            }
            Console.ReadKey();
        }
    }
}
