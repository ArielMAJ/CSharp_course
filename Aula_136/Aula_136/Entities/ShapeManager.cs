using System;
using System.Collections.Generic;
using System.Globalization;
using Aula_136.Entities.Enums;

namespace Aula_136.Entities
{
    internal class ShapeManager
    {
        public List<Shape> shapes { get; protected set; } = new List<Shape>();

        public ShapeManager()
        {
        }
        public void addShapes()
        {
            Console.Write("Enter the number of shapes: ");
            int amount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= amount; i++)
            {
                addShape(i);
            }

        }

        public void addShape(int i_th = 1)
        {
            Console.WriteLine($"Shape #{i_th} data:");

            Console.Write("Rectangle or Circle (r/c): ");
            string typeOfShape = Console.ReadLine().ToLower();
            Console.Write("Color (Black/Blue/Red): ");
            ObjColor color = Enum.Parse<ObjColor>(Console.ReadLine().ToUpper());


            if (typeOfShape == "r")
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Rectangle(width, height, color));
            }
            else if (typeOfShape == "c")
            {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Circle(radius, color));
            }
            else
            {
                Console.WriteLine("Incorrect type of shape selected. Skipping this shape...");
            }
        }

        public void ShapeAreas()
        {
            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }


    }
}
