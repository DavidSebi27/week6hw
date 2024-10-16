using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Circle
    {
        private double _radius;

        public Circle(double Radius)
        {
            _radius = Radius;
        }

        public double Area { get { return Math.PI * Math.Pow(_radius, 2); } }

        public void DisplayInfo()
        {
            Console.WriteLine($"Radius {_radius}\nArea: {Area: 0.00}");
        }
    }
}
