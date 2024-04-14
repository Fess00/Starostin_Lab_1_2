using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sd2
{
    internal interface IDrawable
    {
        void Draw(int n);
        void SaveSVG();
    }
}
