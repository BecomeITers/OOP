using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xi_lăng
{
    internal class Cylinder : Circle
    {
        public double Height {  get; set; }

        public Cylinder() : base()
        {
            Height = 1.0;
        }

        public Cylinder(double height, double radius, string colour) : base(radius, colour)
        {
            this.Height = height;
        }

        public new string toString()
        {
            string str = $"Circle [ radius = {Radius}, color = {Colour}, height = {Height} ]";
            return str;
        }
        public double getVolume()
        {
            double TheTich = base.getArea() * Height;
            return TheTich;
        }   
    }
}
