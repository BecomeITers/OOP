using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Đọc_ghi_file
{
    internal class QuanLy
    {
        private List<SanPham> sp = new List<SanPham>();

        public void Save()
        {
            try
            {
                foreach (var line in File.ReadAllLines("sanpham.txt"))
                {
                    var parts = line.Split(';');
                    string loaiSanPham = parts[0];
                    string maSanPham = parts[1];
                    string tenSanPham = parts[2];
                    double donGia = double.Parse(parts[3]);
                    int soLuong = int.Parse(parts[4]);

                    switch (loaiSanPham)
                    {
                        case "DienTu":
                            int baoHanh = int.Parse(parts[5]);
                            sp.Add(new DienTu(maSanPham, tenSanPham, donGia, soLuong, baoHanh));
                            break;

                        case "ThucPham":
                            string hanSuDung = parts[5];
                            sp.Add(new ThucPham(maSanPham, tenSanPham, donGia, soLuong, hanSuDung));
                            break;

                        case "DoGom":
                            string ngheNhan = parts[5];
                            sp.Add(new DoGom(maSanPham, tenSanPham, donGia, soLuong, ngheNhan));
                            break;
                    }
                }

                using (StreamWriter writer = new StreamWriter("ketqua.txt"))
                {
                    double totalValue = 0;
                    foreach (var sanPham in sp)
                    {
                        writer.WriteLine(sanPham.toString());
                        totalValue += sanPham.DonGia * sanPham.SoLuong;
                    }
                    writer.WriteLine($"\nTong gia tri hang hoa: {totalValue}");
                }

                Console.WriteLine("Ghi file ketqua.txt thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đọc/ghi file: " + ex.Message);
            }
        }
    }
}
