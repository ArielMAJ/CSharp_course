using System;
using System.Collections.Generic;
using Aula_136.Entities.Enums;

namespace Aula_136.Entities
{
    internal abstract class Shape
    {
        public ObjColor Color { get; set; }

        protected Shape(ObjColor color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
