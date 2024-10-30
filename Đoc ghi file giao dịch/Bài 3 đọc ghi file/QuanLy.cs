using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
namespace Bài_3_đọc_ghi_file
{
    internal class QuanLy
    {
        List<GiaoDich> gd = new List<GiaoDich>();
        public void Save()
        {
            try
            {
                foreach (var line in File.ReadAllLines("giaodich.txt"))
                {
                    var parts = line.Split(';');
                    string loaiGiaoDich = parts[0];
                    string maGiaoDich = parts[1];
                    string ngayGiaoDich = parts[2];
                    double donGia = double.Parse(parts[3], CultureInfo.InvariantCulture);
                    int soLuong = int.Parse(parts[4]);

                    switch (loaiGiaoDich)
                    {
                        case "Vang":
                            // Hàm Trim() là loại bỏ các khoảng trắng hoặc ký tự ko mong muốn
                            string loaiVang = parts[5].Split(':')[1].Trim(); // Lấy dữ liệu sau dấu :
                            gd.Add(new GiaoDichVang(maGiaoDich, ngayGiaoDich, donGia, soLuong, loaiVang));
                            break;

                        case "TienTe":
                            string loaiTien = parts[5].Split(':')[1].Trim();
                            double tyGia = double.Parse(parts[6].Split(':')[1].Trim(), CultureInfo.InvariantCulture);
                            gd.Add(new GiaoDichTienTe(maGiaoDich, ngayGiaoDich, donGia, soLuong, loaiTien, tyGia));
                            break;
                    }
                }


                using (StreamWriter writer = new StreamWriter("ketqua_giaodich.txt"))
                {
                    double totalValue = 0;
                    foreach (var giaodich in gd)
                    {
                        writer.WriteLine(giaodich.toString());
                        totalValue += giaodich.DonGia * giaodich.SoLuong;
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
