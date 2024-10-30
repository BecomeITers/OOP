using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Đọc_ghi_file_quản_lý_nhân_viên
{
    internal class QuanLy
    {
        private List<NhanVien> nv = new List<NhanVien>();

        public void Save()
        {
            try
            {
                foreach(var line in File.ReadAllLines("nhanvien.txt"))
                {
                    var parts = line.Split(';');
                    string loaiNhanVien = parts[0];
                    string maNV = parts[1];
                    string tenNV = parts[2];
                    double luongCB = double.Parse(parts[3]);

                    switch (loaiNhanVien)
                    {
                        case "HanhChinh":
                            int soNgayLam = int.Parse(parts[4]);
                            nv.Add(new NhanVienHanhChinh(maNV, tenNV, luongCB, soNgayLam));
                            break;

                        case "SanXuat":
                            int soSanPham = int.Parse(parts[4]);
                            nv.Add(new NhanVienSanXuat(maNV, tenNV, luongCB, soSanPham));
                            break;
                    }
                }

                using (StreamWriter writer = new StreamWriter("ketqua_nhanvien.txt"))
                {
                    double totalValue = 0;
                    foreach (var nhanvien in nv)
                    {
                        writer.WriteLine(nhanvien.toString());
                        totalValue += nhanvien.TinhLuong();
                    }
                    writer.WriteLine($"\nTong gia tri: {totalValue}");
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
