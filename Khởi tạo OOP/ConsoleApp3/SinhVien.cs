using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SinhVien // Tạo lớp (class)
    {
        // Thuộc tính (properties)
        private int maSo;
        private string hoTen;
        private string namSinh; 
        public int MaSo // Phương thức (methods)
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        public SinhVien()
        {
            maSo = 0;
            hoTen = namSinh = "";
        }
        public SinhVien(int maSo, string hoTen, string namSinh)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NamSinh = namSinh;
        }
    }
}
