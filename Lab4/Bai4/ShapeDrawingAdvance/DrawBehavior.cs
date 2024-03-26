using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawingAdvance
{
    public interface ILineBehavior
    {
        Pen GetPenLine(Color color);
    }

    public class SolidLine : ILineBehavior
    {
        public Pen GetPenLine(Color color)
        {
            return new Pen(color, 3);
        }
    }

    public class DashLine : ILineBehavior
    {
        public Pen GetPenLine(Color color)
        {
            return new Pen(color, 3) { DashStyle = DashStyle.Dash };
        }
    }

    public interface IPaintBehavior
    {
        Brush? GetBrushPaint();
    }

    public class EmptyPaint : IPaintBehavior
    {
        public Brush? GetBrushPaint()
        {
            return null;
        }
    }

    public class ColorPaint : IPaintBehavior
    {
        private Color Color;
        public ColorPaint(Color color)
        {
            Color = color;
        }

        public Brush? GetBrushPaint()
        {
            return new SolidBrush(Color);
        }
    }
}