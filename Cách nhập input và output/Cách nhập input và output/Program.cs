using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cách_nhập_input_và_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.Nhap();
            sv.In();
            Console.ReadKey(); // Đây là phương thức giúp người nhập ấn bất kỳ phím nào tự động thoát cmd
        }
    }
}
