using Aula_136.Entities.Enums;
using System;

namespace Aula_136.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, ObjColor color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
