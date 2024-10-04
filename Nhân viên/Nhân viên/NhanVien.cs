using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên
{
    internal class NhanVien
    {
        private String hoTen;
        private string ngaySinh;
        private DiaChi diachi;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        internal DiaChi Diachi { get => diachi; set => diachi = value; }

        public NhanVien()
        {
            hoTen = string.Empty;
            ngaySinh= string.Empty;
        }

        public NhanVien(string hoTen, string ngaySinh, DiaChi diachi)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.Diachi = diachi;
        }
        
        DiaChi address = new DiaChi();

        public void Nhap()
        {
            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NgaySinh = Console.ReadLine();
            address.Nhap();
        }

        public void In()
        {
            Console.WriteLine($"Ho va ten la: {HoTen}");
            Console.WriteLine($"Nam sinh la : {NgaySinh}");
            address.In();
        }
    }
}
