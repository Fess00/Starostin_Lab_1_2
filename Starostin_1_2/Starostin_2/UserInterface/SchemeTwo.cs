using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Starostin_2
{
    internal class SchemeTwo : VisualCurve
    {
        public SchemeTwo(ICurve curve) : base(curve)
        {
            
        }

        public override void Draw(int n)
        {
            IPoint[] points = new IPoint[n];
            System.Drawing.PointF[] p = new System.Drawing.PointF[n];
            Bitmap bitmap = new Bitmap(Convert.ToInt32(512), Convert.ToInt32(512));
            Graphics g = Graphics.FromImage(bitmap);
            GraphicsPath path = new GraphicsPath();
            g.Clear(System.Drawing.Color.White);
            Pen pen = new Pen(System.Drawing.Color.Black, 5);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;

            for (int i = 0; i <= n - 1; i++)
            {
                points[i] = new Point();
                curve.GetPoint((Convert.ToDouble(i) / Convert.ToDouble(n - 1)), out points[i]);
                p[i] = new System.Drawing.PointF((float)points[i].X, (float)points[i].Y);
            }
            path.AddCurve(p);
            g.DrawPath(pen, path);
            bitmap.Save(@"C:\Users\MagicWheel\Documents\Code_Base\C#\Starostin_Lab_1_2\Starostin_1_2\Starostin_2\Resources\Images\secondschemeimage.png",
                System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
