using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cách_nhập_input_và_output
{
    class SinhVien
    {
        public int MaSo {  get; set; }  
        public string HoTen {  get; set; }
        public void Nhap()
        {
            // ReadLine là input giá trị vào tên biến
            Console.Write("Nhap ma so: ");
            MaSo = int.Parse(Console.ReadLine()); // Hàm biến đổi từ string thành int lưu vào MaSo
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine(); 

        }
        public void In()
        {
            Console.WriteLine($"Ma so la: {MaSo}"); // Dấu "$" là chèn {} vào giá trị của tên biến
            Console.WriteLine($"Ho ten la: {HoTen}");
        }
    }
}
