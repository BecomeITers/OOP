using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danh_sách_tiền_tệ_và_vàng
{
    internal class QuanLyGiaoDich
    {
        private List<GiaoDich> giaodich = new List<GiaoDich>();
        public void NhapGiaoDich()
        {
            Console.Write("Nhap so luong giao dich: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                Console.Write("Nhap loai giao dich (Vang / Tien te): ");
                string LoaiGiaoDich = Console.ReadLine();

                Console.Write("Nhap ma giao dich: ");
                string maGiaoDich = Console.ReadLine();

                Console.Write("Nhap ngay giao dich: ");
                string ngayGiaoDich = Console.ReadLine();

                Console.Write("Nhap don gia: ");
                double donGia = double.Parse(Console.ReadLine());

                Console.Write("Nhap so luong: ");
                int soLuong = int.Parse(Console.ReadLine());

                if (LoaiGiaoDich == "Vang")
                {
                    Console.Write("Nhap loai vang: ");
                    string loaiVang = Console.ReadLine();

                    GiaoDichVang gdvang = new GiaoDichVang(maGiaoDich, ngayGiaoDich, donGia, soLuong, loaiVang);
                    giaodich.Add(gdvang);
                }

                else if(LoaiGiaoDich == "Tien te")
                {
                    Console.Write("Nhap loai tien te: ");
                    string loaiTienTe = Console.ReadLine();

                    Console.Write("Nhap ti gia: ");
                    double tiGia = double.Parse(Console.ReadLine());

                    GiaoDichTienTe gdtiente = new GiaoDichTienTe(maGiaoDich, ngayGiaoDich, donGia, soLuong, loaiTienTe, tiGia);
                    giaodich.Add(gdtiente);
                }

            }
        }

        public void InGiaoDich()
        {
            foreach(var giaoDich in giaodich)
            {
                Console.WriteLine(giaoDich.toString()); 
            }
        }


    }
}
