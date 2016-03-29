using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlittchModel
{
    public class Link
    {
        public Link(Point center, int length)
        {
            CenterOfRotation = center;
            Length = length;
        }

        public Point CenterOfRotation { get; set; }
        public Point EndPoint
        {
            get
            {
                return new Point(CenterOfRotation.X + Length, CenterOfRotation.Y);
            }
        }
        public int Length;
    }
}
