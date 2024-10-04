using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thời_gian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time tg = new Time();
            tg.Nhap();
            Console.WriteLine(tg.toString());
            Console.WriteLine(tg.NextSecond());
            Console.WriteLine(tg.PreviousSecond());
            Console.ReadKey();
        }
    }
}
