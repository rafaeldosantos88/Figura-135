using System;
using System.Collections.Generic;
using System.Text;
using Figura.Entities.Enums;

namespace Figura.Entities
{
    class Circle :Shape
    {
        public double Radius{ get; set; }  //Raio do circulo

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
