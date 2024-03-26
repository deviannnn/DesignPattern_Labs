using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawing
{
    public abstract class Shape
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Color Color { get; set; } = Color.Black;

        public abstract void Draw(Graphics g);
        public abstract bool Include(Point p);
    }

    public abstract class Triangle : Shape
    {
        public sealed override void Draw(Graphics g)
        {
            var p1 = SetPoint1();
            var p2 = SetPoint2();
            var p3 = SetPoint3();

            using (Pen pen = new(Color, 3))
            {
                g.DrawLine(pen, p1, p2);
                g.DrawLine(pen, p1, p3);
                g.DrawLine(pen, p2, p3);
            }
        }

        public abstract Point SetPoint1();
        public abstract Point SetPoint2();
        public abstract Point SetPoint3();

        public sealed override bool Include(Point p)
        {
            var p1 = SetPoint1();
            var p2 = SetPoint2();
            var p3 = SetPoint3();

            var path = new GraphicsPath();
            path.AddPolygon(new Point[] { p1, p2, p3 });
            var region = new Region(path);
            return region.IsVisible(p);
        }
    }

    public class RightTriangle : Triangle
    {
        public override Point SetPoint1()
        {
            return new Point(Math.Min(A.X, B.X), B.Y > A.Y ? Math.Max(A.Y, B.Y) : Math.Min(A.Y, B.Y));
        }

        public override Point SetPoint2()
        {
            return new Point(Math.Max(A.X, B.X), Math.Min(A.Y, B.Y));
        }

        public override Point SetPoint3()
        {
            return new Point(Math.Max(A.X, B.X), Math.Max(A.Y, B.Y));
        }
    }

    public class LeftTriangle : Triangle
    {
        public override Point SetPoint1()
        {
            return new Point(Math.Max(A.X, B.X), B.Y > A.Y ? Math.Max(A.Y, B.Y) : Math.Min(A.Y, B.Y));
        }

        public override Point SetPoint2()
        {
            return new Point(Math.Min(A.X, B.X), Math.Min(A.Y, B.Y));

        }

        public override Point SetPoint3()
        {
            return new Point(Math.Min(A.X, B.X), Math.Max(A.Y, B.Y));

        }
    }

    public class IsoscelesTriangle : Triangle
    {
        public override Point SetPoint1()
        {
            return new Point((A.X + B.X) / 2, A.Y);
        }

        public override Point SetPoint2()
        {
            return new Point(A.X, B.Y);
        }

        public override Point SetPoint3()
        {
            return B;
        }
    }

    public class EquilateralTriangle : Triangle
    {
        public override Point SetPoint1()
        {
            Point C = new Point(A.X, B.Y);
            double distanceToA, distanceToB;
            CalculateDistances(C, out distanceToA, out distanceToB);

            if (distanceToB > distanceToA)
            {
                int offsetX = B.X > A.X ? (int)(distanceToA / Math.Sqrt(3)) : -(int)(distanceToA / Math.Sqrt(3));
                return new Point(A.X + offsetX, A.Y);
            }
            else
            {
                int offsetX = B.X > A.X ? -(int)(distanceToB / 2) : (int)(distanceToB / 2);
                int offsetY = B.Y > A.Y ? -(int)(distanceToB * Math.Sqrt(3) / 2) : (int)(distanceToB * Math.Sqrt(3) / 2);
                return new Point(B.X + offsetX, B.Y + offsetY);
            }
        }

        public override Point SetPoint2()
        {
            return new Point(A.X, B.Y);
        }

        public override Point SetPoint3()
        {
            Point C = new Point(A.X, B.Y);
            double distanceToA, distanceToB;
            CalculateDistances(C, out distanceToA, out distanceToB);

            if (distanceToB > distanceToA)
            {
                int offsetX = B.X > A.X ? (int)(2 * distanceToA / Math.Sqrt(3)) : -(int)(2 * distanceToA / Math.Sqrt(3));
                return new Point(A.X + offsetX, B.Y);
            }
            else
            {
                return B;
            }
        }

        private void CalculateDistances(Point C, out double distanceToA, out double distanceToB)
        {
            distanceToA = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
            distanceToB = Math.Sqrt(Math.Pow(B.X - C.X, 2) + Math.Pow(B.Y - C.Y, 2));
        }
    }

    public class Circle : Shape
    {
        protected Rectangle GetRectangle()
        {
            int x = Math.Min(A.X, B.X);
            int y = Math.Min(A.Y, B.Y);
            var edge = Math.Min(Math.Abs(A.X - B.X), Math.Abs(A.Y - B.Y));

            return new Rectangle(new Point(x, y), new Size(edge, edge));
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color, 3), GetRectangle());
        }

        public override bool Include(Point p)
        {
            var edge = Math.Min(Math.Abs(A.X - B.X), Math.Abs(A.Y - B.Y));
            double radius = edge / 2;

            double centerX = B.X > A.X ? A.X + radius : B.X + radius;
            double centerY = B.Y > A.Y ? A.Y + radius : B.Y + radius;
            
            double distanceSquared = Math.Pow(p.X - centerX, 2) + Math.Pow(p.Y - centerY, 2);

            return distanceSquared <= Math.Pow(radius, 2);
        }
    }

    public class SolidCircle : Circle
    {
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), GetRectangle());
        }
    }

    public class Square : Shape
    {
        protected Rectangle GetRectangle()
        {
            int x = Math.Min(A.X, B.X);
            int y = Math.Min(A.Y, B.Y);
            var edge = Math.Min(Math.Abs(A.X - B.X), Math.Abs(A.Y - B.Y));

            return new Rectangle(new Point(x, y), new Size(edge, edge));
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color, 3), GetRectangle());
        }

        public override bool Include(Point p)
        {
            var edge = Math.Min(Math.Abs(A.X - B.X), Math.Abs(A.Y - B.Y));
            double radius = edge / 2;

            double centerX = B.X > A.X ? A.X + radius : B.X + radius;
            double centerY = B.Y > A.Y ? A.Y + radius : B.Y + radius;

            return Math.Abs(p.X - centerX) <= radius && Math.Abs(p.Y - centerY) <= radius;
        }
    }

    public class SolidSquare : Square
    {
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), GetRectangle());
        }
    }

    public class RectangleShape : Shape
    {
        protected Rectangle GetRectangle()
        {
            int x = Math.Min(A.X, B.X);
            int y = Math.Min(A.Y, B.Y);
            int width = Math.Abs(A.X - B.X);
            int height = Math.Abs(A.Y - B.Y);

            return new Rectangle(new Point(x, y), new Size(width, height));
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color, 3), GetRectangle());
        }

        public override bool Include(Point p)
        {
            return GetRectangle().Contains(p);
        }
    }

    public class SolidRectangle : RectangleShape
    {
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), GetRectangle());
        }
    }

    public enum ShapeType
    {
        RightTri, LeftTri, IsoscelesTri, EquilateralTri, Circle, SolidCircle, Square, SolidSquare, Rectangle, SolidRectangle
    }

    public class ShapeFactory
    {
        public static Shape CreateShape(ShapeType type)
        {
            return type switch
            {
                ShapeType.RightTri => new RightTriangle(),
                ShapeType.LeftTri => new LeftTriangle(),
                ShapeType.IsoscelesTri => new IsoscelesTriangle(),
                ShapeType.EquilateralTri => new EquilateralTriangle(),
                ShapeType.Circle => new Circle(),
                ShapeType.SolidCircle => new SolidCircle(),
                ShapeType.Square => new Square(),
                ShapeType.SolidSquare => new SolidSquare(),
                ShapeType.Rectangle => new RectangleShape(),
                ShapeType.SolidRectangle => new SolidRectangle(),
                _ => throw new ArgumentException("Invalid Shape type"),
            };
        }
    }
}
