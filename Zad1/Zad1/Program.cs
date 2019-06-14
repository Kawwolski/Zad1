using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
            a.X = 2.0;
            a.Y = 2.0;

            Point b = new Point();
            b.X = 6.0;
            b.Y = 7.0;

            LineSegment line = new LineSegment();
            line.SetPoint1(a);
            line.SetPoint2(b);

            Console.WriteLine("srodkowy pkt. odcinka x : " + line.GetCenter().X.ToString());
            Console.WriteLine("srodkowy pkt. odcinka y : " + line.GetCenter().Y.ToString());
            Console.WriteLine("dlugosc odcinka: " + line.GetLength().ToString());
            Console.ReadKey();
        }
    }
}
