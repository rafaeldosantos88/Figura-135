using System;
using System.Collections.Generic;
using System.Text;
using Figura.Entities.Enums;


namespace Figura.Entities
{
    class Rectangle : Shape                            //vai herda da classe shape
    {
         public double  Width { get; set; }           //largura
        public double Height { get; set; }           //Altura


        public Rectangle(double width,double heigth,Color color) : base(color)
        {
            Width = width;
           Height = heigth;

        }
        public override double Area()               //Calculando Area
        {
            return Width * Height;
        }
    }
}
