using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public void SetRadius(double newRadius)
        {
            _radius = newRadius;
        }

        public double GetRadius()
        {
            return _radius;
        }

        public double CalculateCircumference(double radius)
        {
            double diameter = radius * 2;
            double circumference = Math.PI * diameter;
            return circumference;
        }

        public string CalculateFormattedCircumference(double radius)
        {
            double diameter = radius * 2;
            double circumference = Math.PI * diameter;
            double formattedCircumference = Math.Round(circumference, 2);
            string formattedCircumferenceString = Convert.ToString(formattedCircumference);
            return formattedCircumferenceString;
        }

        public double CalculateArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        
        public string CalculateFormattedArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            double formattedArea = Math.Round(area, 2);
            string formattedAreaString = Convert.ToString(formattedArea);
            return formattedAreaString;
        }

        private double FormatNumber(double x)
        {
            double formattedNumber = Math.Round(x, 2);
            return formattedNumber;
        }
    }
}
