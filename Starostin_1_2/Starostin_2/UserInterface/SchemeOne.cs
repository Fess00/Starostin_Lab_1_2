using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starostin_2
{
    internal class SchemeOne : VisualCurve
    {
        public SchemeOne(ICurve curve) : base(curve)
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
            Pen pen = new Pen(System.Drawing.Color.Green, 5);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            
            for (int i = 0; i <= n - 1; i++)
            {
                points[i] = new Point();
                curve.GetPoint((Convert.ToDouble(i) / Convert.ToDouble(n - 1)), out points[i]);
                p[i] = new System.Drawing.PointF((float)points[i].X, (float)points[i].Y);
            }
            path.AddCurve(p);
            g.DrawPath(pen, path);
            bitmap.Save(@"C:\Users\MagicWheel\Documents\Code_Base\C#\Starostin_Lab_1_2\Starostin_1_2\Starostin_2\Resources\Images\firstschemeimage.png", 
                System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
