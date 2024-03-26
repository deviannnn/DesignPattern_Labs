using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    public class SimpleShapeFactory
    {
        public Shape createShape(int shape, int type)
        {
            return type switch
            {
                2 => shape switch
                {
                    1 => new SolidCircle(),
                    2 => new SolidSquares(),
                    _ => new SolidRectangle(),
                },
                _ => shape switch
                {
                    1 => new Circle(),
                    2 => new Squares(),
                    _ => new Rectangle(),
                },
            };
            ;
        }
    }
}
