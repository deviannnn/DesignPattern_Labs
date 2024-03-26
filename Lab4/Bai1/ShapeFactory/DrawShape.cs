using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    public class DrawShape
    {
        SimpleShapeFactory factory;

        public DrawShape(SimpleShapeFactory factory)
        {
            this.factory = factory;
        }

        public void draw(int shape, int type)
        {
            Shape s;
            s = factory.createShape(shape, type);
            s.draw();
        }
    }
}
