using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starostin_1
{
    abstract class VisualCurve : ICurve, IDrawable
    {
        public abstract void Draw(ICurve curve);

        public virtual void GetPoint(double t, out IPoint p)
        {
            p = new Point();
        }
    }
}
