using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starostin_1
{
    internal class VisualLine : VisualCurve
    {
        public override void Draw(ICurve curve)
        {
            curve.GetPoint(0, out IPoint a);
            curve.GetPoint(1, out IPoint b);
            Console.WriteLine($"Line 0: x {a.X} y {a.Y}, 1: x {b.X} y {b.Y}");
        }
    }
}
