using System;
using System.Globalization;
using Aula_136.Entities;

namespace Aula_133
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager shapeManager = new ShapeManager();

            shapeManager.addShapes();
            shapeManager.ShapeAreas();

        }
    }
}
