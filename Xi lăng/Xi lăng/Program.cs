using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xi_lăng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder xilang = new Cylinder();
            Console.WriteLine("So do la: ");
            Console.WriteLine(xilang.toString());
            Console.Write($"The tich la: {xilang.getVolume()}");
            Console.ReadKey();
        }
    }
}
