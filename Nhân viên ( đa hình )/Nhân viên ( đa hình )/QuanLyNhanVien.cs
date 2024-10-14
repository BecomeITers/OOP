using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên___đa_hình__
{
    internal class QuanLyNhanVien
    {
        private List<Employee> nhanvien = new List<Employee>();
        public void Nhap()
        {
            Console.Write("Nhap so luong danh sach nhan vien: ");
            int num = int.Parse(Console.ReadLine());
            for(int i  = 0; i < num; i++)
            {
                Console.Write("Nhap loai nhan vien (Hourly/Salaried): ");
                string loaiNhanVien = Console.ReadLine();

                Console.Write("Nhap ma nhan vien: ");
                string empCode = Console.ReadLine();

                Console.Write("Nhap ten truoc: ");
                string firstName = Console.ReadLine();

                Console.Write("Nhap ten sau: ");
                string lastName = Console.ReadLine();

                if(loaiNhanVien == "Hourly")
                {
                    Console.Write("Nhap ty le: ");
                    double rate = double.Parse(Console.ReadLine());

                    Console.Write("NHap thoi gian lam viec: ");
                    double workingHours = double.Parse(Console.ReadLine());

                    HourlyEmployee nvgio = new HourlyEmployee(empCode, firstName, lastName, rate, workingHours);
                    nhanvien.Add(nvgio);
                }
                else if(loaiNhanVien == "Salaried")
                {
                    Console.Write("Nhap ty le hoa hong: ");
                    double commisionRate = double.Parse(Console.ReadLine());

                    Console.Write("Nhap doanh so: ");
                    double grossSales = double.Parse(Console.ReadLine());

                    Console.Write("Nhap luong co ban: ");
                    double basic = double.Parse(Console.ReadLine());

                    SalariedEmployee nvtien = new SalariedEmployee(empCode, firstName, lastName, commisionRate, grossSales, basic);
                    nhanvien.Add(nvtien);
                }
            }
        }

        public void In()
        {
            foreach(var nv in nhanvien)
            {
                Console.WriteLine(nv.toString());
            }
        }

        public void TongSoLuong()
        {
            double TongSoLuongGio = nhanvien.OfType<HourlyEmployee>().Sum(nv => nv.Pay());
            double TongSoLuongTien = nhanvien.OfType<SalariedEmployee>().Sum(nv => nv.Pay());
            double Sum = TongSoLuongGio + TongSoLuongTien;

            Console.WriteLine($"Tong so luong cua nhan vien gio la: {TongSoLuongGio}");
            Console.WriteLine($"Tong so luong cua nhan vien tien la: {TongSoLuongTien}");
            Console.WriteLine($"Tong so luong cua nhan vien la: {Sum}");
        }

        public void TongSo()
        {
            int nvgio = nhanvien.OfType<HourlyEmployee>().Count();
            int nvtien = nhanvien.OfType<SalariedEmployee>().Count();

            Console.WriteLine($"Tong so nhan vien gio la: {nvgio}");
            Console.WriteLine($"Tong so nhan vien tien la: {nvtien}");
        }

        public void InNVGio()
        {
            var nvgio = nhanvien.OfType<HourlyEmployee>();
            if (nvgio.Any())
            {
                foreach(var nv in nvgio)
                {
                    Console.WriteLine(nv.toString());
                }
                Console.Write("--------------");
            }
            else
            {
                Console.WriteLine("Ko co danh sach!");
            }
        }
    }
}
