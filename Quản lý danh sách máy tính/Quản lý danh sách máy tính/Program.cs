using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_danh_sách_máy_tính
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong may tinh: ");
            int num = int.Parse( Console.ReadLine() );
            Computer[] maytinh = new Computer[num];
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Nhap may tinh thu {i + 1}");
                maytinh[i] = new Computer();
                maytinh[i].Nhap();
            }

            int cnt = 0;
            for(int i = 0; i < num; i++)
            {
                if (maytinh[i].ThongKe(1)){
                    cnt++;
                }
            }
            Console.WriteLine($"Co {cnt} may bao hanh 1 nam");

            for(int i = 0; i < num; i++)
            {
                if(maytinh[i].NoiSanXuat == "My"){
                    maytinh[i].In();
                }
            }

            int cntnum = 0;
            for(int i = 0; i < num; i++)
            {
                cntnum = maytinh[i].getDem();
            }
            Console.Write($"So luong doi tuong may tinh la: {cntnum}");
            Console.ReadKey();
        }
    }
}
