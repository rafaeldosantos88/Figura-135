using System;
using Figura.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Figura.Entities
{
    abstract class Shape                                //Classe figura,Eu fui obrigado colocar também que classe é abstrata por causa do metodo
    {
        public Color  Color { get; set; }               //O tipo vai Color(ENUM) E O NOME Color também

       

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();              //Porém a figura é de um tipo muito generico não tem como Eu calcular uma area baseado em um tipo tão generico assim.Então operação vai ser abstrata
    }
}
