using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starostin_2
{
    abstract class VisualCurve : ICurve, IDrawable
    {
        protected ICurve curve;

        public VisualCurve(ICurve curve)
        {
            this.curve = curve;
        }

        public abstract void Draw(int n);

        public virtual void GetPoint(double t, out IPoint p)
        {
            curve.GetPoint(t, out p);
        }
    }
}
