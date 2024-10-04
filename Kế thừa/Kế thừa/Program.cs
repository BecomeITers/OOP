using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kế_thừa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XeKhach xekhach = new XeKhach();
            xekhach.Nhap();
            xekhach.In();
            Console.ReadKey();
        }
    }
}
