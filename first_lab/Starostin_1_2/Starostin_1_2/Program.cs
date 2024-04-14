using Microsoft.VisualBasic.FileIO;
using Starostin_1;

Line line = new Line(new Point(2, 3), new Point(6, 18));
VisualLine visualLine = new VisualLine();
visualLine.Draw(line);
visualLine.GetPoint(1, out IPoint p);