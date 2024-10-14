using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên
{
    internal class QuanLyNhanVien
    {
        private List<NhanVien> nv = new List<NhanVien>();

        public void Nhap()
        {
            Console.Write("Nhap so luong danh sach: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.Write("Nhap loai nhan vien (NVBC/NVHD): ");
                string loaiNhanVien = Console.ReadLine();

                Console.Write("Nhap ma so: ");
                string maSo = Console.ReadLine();

                Console.Write("Nhap ho ten: ");
                string hoTen = Console.ReadLine();

                Console.Write("Nhap nam sinh: ");
                string namSinh = Console.ReadLine();

                if (loaiNhanVien == "NVBC")
                {
                    Console.Write("Nhap luong can ban: ");
                    double luongCB = double.Parse(Console.ReadLine());

                    Console.Write("Nhap he so luong: ");
                    double heSoLuong = double.Parse(Console.ReadLine());

                    Console.Write("Nhap tien phu cap: ");
                    double tienPhuCap = double.Parse(Console.ReadLine());

                    NVBC nvbc = new NVBC(maSo, hoTen, namSinh, luongCB, heSoLuong, tienPhuCap);
                    nv.Add(nvbc);
                }

                else if(loaiNhanVien == "NVHD")
                {
                    Console.Write("Nhap tien cong lao dong trong 1 gio: ");
                    double tienCong = double.Parse(Console.ReadLine());

                    Console.Write("Nhap so gio lam viec trong 1 thang: ");
                    double soGio = double.Parse(Console.ReadLine());

                    NVHD nvhd = new NVHD(maSo, hoTen, namSinh, tienCong, soGio);
                    nv.Add(nvhd);
                }

                else
                {
                    Console.WriteLine("Invalid type of Employee!");
                    break;
                }
            }
        }

        public void In()
        {
            foreach(var nhanvien in nv)
            {
                Console.WriteLine(nhanvien.toString());
            }
        }

        public void Tong()
        {
            double luongNVBC = nv.OfType<NVBC>().Sum(nv => nv.Luong());
            double luongNVHD = nv.OfType<NVHD>().Sum(nv => nv.Luong());
            double sum = luongNVBC + luongNVHD;

            Console.WriteLine($"Tong so luong la: {sum}");
        }

        public void Tim()
        {
            Console.Write("Nhap nhan vien tim: ");
            string timNhanVien = Console.ReadLine();

            var nhanvien = nv.FirstOrDefault(nv => nv.hoTen == timNhanVien);

            if (nhanvien != null)
            {
                Console.WriteLine("Da tim thay nhan vien!");
                Console.WriteLine(nhanvien.toString());
            }
            else
            {
                Console.WriteLine("Ko co trong danh sach");
            }
        }

        public void Xuat()
        {
            var minLuong = nv.Min(nv => nv.Luong());
            var maxLuong = nv.Max(nv => nv.Luong());

            // Hàm FirstOrDefault tìm ra nhân viên có mức lương tương ứng
            var nvMinLuong = nv.FirstOrDefault(nv => nv.Luong() == minLuong);
            var nvMaxLuong = nv.FirstOrDefault(nv => nv.Luong() == maxLuong);

            Console.WriteLine("Nhan vien luong thap nhat: ");
            Console.WriteLine(nvMinLuong.toString());

            Console.WriteLine("Nhan vien luong cao nhat: ");
            Console.WriteLine(nvMaxLuong.toString());
        }
    }
}
