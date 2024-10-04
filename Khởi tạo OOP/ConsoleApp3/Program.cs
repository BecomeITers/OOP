using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien(1,"Nguyen Van A", "23/12/2005");
            Console.WriteLine(sv.MaSo);
            Console.WriteLine(sv.HoTen);
            Console.WriteLine(sv.NamSinh);
        }
    }
}
