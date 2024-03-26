using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    public class Shape
    {
        public Shape() { }

        public virtual void draw() => Console.WriteLine("Unknow Shape!");
    }

    public class SolidCircle : Shape
    {
        public override void draw() => Console.WriteLine("SolidCircle!");
    }

    public class SolidSquares : Shape
    {
        public override void draw() => Console.WriteLine("SolidSquares!");
    }

    public class SolidRectangle : Shape
    {
        public override void draw() => Console.WriteLine("SolidRectangle!");
    }

    public class Circle : Shape
    {
        public override void draw() => Console.WriteLine("Circle!");
    }

    public class Squares : Shape
    {
        public override void draw() => Console.WriteLine("Squares!");
    }

    public class Rectangle : Shape
    {
        public override void draw() => Console.WriteLine("Rectangle!");
    }
}
