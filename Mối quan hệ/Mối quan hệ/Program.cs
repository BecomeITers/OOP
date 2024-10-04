
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mối_quan_hệ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiaChi dc = new DiaChi("Thu Duc", "HCM");
            Person ps = new Person("Nam", dc);
            Console.WriteLine(ps.HienThi());
            Console.ReadKey();

        }
    }
}
