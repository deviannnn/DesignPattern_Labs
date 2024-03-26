using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDrawing
{
    public abstract class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point p3 { get; set; }

        public void Draw(PaintEventArgs e)
        {
            p1 = SetPoint1();
            p2 = SetPoint2();
            p3 = SetPoint3();

            Pen blackPen = new(Color.Black, 3);

            e.Graphics.DrawLine(blackPen, p1, p2);
            e.Graphics.DrawLine(blackPen, p1, p3);
            e.Graphics.DrawLine(blackPen, p2, p3);
        }

        public bool Include(Triangle t)
        {
            bool allEdgesNotIntersect = !DoEdgesIntersect(p1, p2, t.p1, t.p2) &&
                                        !DoEdgesIntersect(p1, p2, t.p2, t.p3) &&
                                        !DoEdgesIntersect(p1, p2, t.p3, t.p1) &&
                                        !DoEdgesIntersect(p2, p3, t.p1, t.p2) &&
                                        !DoEdgesIntersect(p2, p3, t.p2, t.p3) &&
                                        !DoEdgesIntersect(p2, p3, t.p3, t.p1) &&
                                        !DoEdgesIntersect(p3, p1, t.p1, t.p2) &&
                                        !DoEdgesIntersect(p3, p1, t.p2, t.p3) &&
                                        !DoEdgesIntersect(p3, p1, t.p3, t.p1);

            bool allPointsNotIn = !IsPointInsideTriangle(t.p1) &&
                                  !IsPointInsideTriangle(t.p2) &&
                                  !IsPointInsideTriangle(t.p3) &&
                                  !t.IsPointInsideTriangle(p1) &&
                                  !t.IsPointInsideTriangle(p2) &&
                                  !t.IsPointInsideTriangle(p3);

            return allEdgesNotIntersect && allPointsNotIn;
        }

        public bool IsPointInsideTriangle(Point point)
        {
            double alpha, beta, gamma;

            double detT = (p2.Y - p3.Y) * (p1.X - p3.X) + (p3.X - p2.X) * (p1.Y - p3.Y);
            alpha = ((p2.Y - p3.Y) * (point.X - p3.X) + (p3.X - p2.X) * (point.Y - p3.Y)) / detT;
            beta = ((p3.Y - p1.Y) * (point.X - p3.X) + (p1.X - p3.X) * (point.Y - p3.Y)) / detT;
            gamma = 1 - alpha - beta;

            return alpha >= 0 && beta >= 0 && gamma >= 0;
        }

        public static bool DoEdgesIntersect(Point p1, Point p2, Point p3, Point p4)
        {
            int orientation1 = GetOrientation(p1, p2, p3);
            int orientation2 = GetOrientation(p1, p2, p4);
            int orientation3 = GetOrientation(p3, p4, p1);
            int orientation4 = GetOrientation(p3, p4, p2);

            if (orientation1 != orientation2 && orientation3 != orientation4)
                return true;

            if (orientation1 == 0 && OnSegment(p1, p3, p2)) return true;
            if (orientation2 == 0 && OnSegment(p1, p4, p2)) return true;
            if (orientation3 == 0 && OnSegment(p3, p1, p4)) return true;
            if (orientation4 == 0 && OnSegment(p3, p2, p4)) return true;

            return false;
        }

        private static int GetOrientation(Point p1, Point p2, Point p3)
        {
            int val = (p2.Y - p1.Y) * (p3.X - p2.X) - (p2.X - p1.X) * (p3.Y - p2.Y);

            if (val == 0) return 0;
            return (val > 0) ? 1 : 2;
        }

        private static bool OnSegment(Point p, Point q, Point r)
        {
            if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                return true;

            return false;
        }

        public void ChangeColor(PaintEventArgs e)
        {
            Pen redPen = new(Color.Red, 3);

            e.Graphics.DrawLine(redPen, p1, p2);
            e.Graphics.DrawLine(redPen, p1, p3);
            e.Graphics.DrawLine(redPen, p2, p3);
        }

        public abstract Point SetPoint1();
        public abstract Point SetPoint2();
        public abstract Point SetPoint3();
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

    public enum TriangleType
    {
        Right, Left, Isosceles, Equilateral
    }

    public class TriangleFactory
    {
        public static Triangle CreateTriangle(TriangleType type)
        {
            return type switch
            {
                TriangleType.Right => new RightTriangle(),
                TriangleType.Left => new LeftTriangle(),
                TriangleType.Isosceles => new IsoscelesTriangle(),
                TriangleType.Equilateral => new EquilateralTriangle(),
                _ => throw new ArgumentException("Invalid triangle type"),
            };
        }
    }
}
