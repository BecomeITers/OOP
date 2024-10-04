using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xi_lăng
{
    internal class Circle
    {
        private double _radius;
        private string _colour;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public Circle()
        {
            _radius = 1.0;
            _colour = "red";
        }

        public Circle(double radius, string colour)
        {
            this.Radius = radius;
            this.Colour = colour;
        }

        public double getArea()
        {
            double DienTich = Math.PI * Radius * Radius;
            return DienTich;
        }

        public string toString()
        {
            string str = $"Circle [ radius = {Radius}, color = {Colour} ]";
            return str;
        }
    }
}
