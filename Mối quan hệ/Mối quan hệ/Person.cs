using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mối_quan_hệ
{
    internal class Person
    {
        private string hoTen;
        private DiaChi diaChi;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public DiaChi DiaChi
        {
            get { return diaChi; }
            set {  diaChi = value; }
        }
        public Person(string hoTen, DiaChi diaChi)
        {
            this.HoTen = hoTen;
            this.DiaChi = diaChi;  
        }
        public string HienThi()
        {
            return $"{hoTen}, {diaChi.HienThi()}";
        }
    }
}
