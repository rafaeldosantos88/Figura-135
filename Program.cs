using System;
using Figura.Entities;
using Figura.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace Figura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Shape: "); //Entre quantidade de figuras.
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();           //Lista pra percorrer.

            for(int i =1;i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");  //uso da interpolação .Dados da figura.
                Console.Write("Rectangle or Circle(r/c) ?");
                char ch = char.Parse(Console.ReadLine()); //Aqui o usuario vai digitar R ou C.
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r')                        //1ºSe meu usuario digitar r.
                {
                    Console.Write("width: ");      //2ºDigite a largura.lOGO ABAIXO VARIAVEL AUXILIAR width.
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");    //Digita a altura.
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, heigth, color));

                }
                else  // SE é um Circulo
                {
                    Console.Write("Radius: ");   //Digite o Raio do circulo
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Variavel auxiliar temporaria(radius)
                    list.Add(new Circle(radius, color));
                }
                
            }
            //Mostrando e imprimindo as Areas da figura

            Console.WriteLine("______________________________________________________________________________");

            Console.WriteLine("Shape Areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}
