using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biên_lai_khách_hàng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BienLai fee = new BienLai();
            fee.Nhap();
            fee.In();
            Console.ReadKey();
        }
    }
}