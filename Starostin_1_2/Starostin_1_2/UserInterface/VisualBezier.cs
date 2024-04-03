using Starostin_1.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starostin_1.UserInterface
{
    internal class VisualBezier : VisualCurve
    {
        public override void Draw(ICurve curve)
        {
            curve.GetPoint(0, out IPoint a);
            curve.GetPoint(0.33, out IPoint b);
            curve.GetPoint(0.66, out IPoint c);
            curve.GetPoint(1, out IPoint d);
            Console.WriteLine($"Bezier curve 0: x {a.X} y {a.Y}, 1: x {b.X} y {b.Y}, 2: x {c.X} y {c.Y}, 3: x {d.X} y {d.Y}");
        }
    }
}
