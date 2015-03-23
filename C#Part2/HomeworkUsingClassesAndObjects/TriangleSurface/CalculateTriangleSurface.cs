//Write methods that calculate the surface of a triangle by given:
    //Side and an altitude to it;
    //Three sides;
    //Two sides and an angle between them;
//Use System.Math.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CalculateTriangleSurface
{
    static void Main()
    {
        Console.WriteLine("a = 4, h = 6, s = {0}", TriangleSurface(4, 6));
        Console.WriteLine("a = 4, b = 5, c = 6, s = {0}", TriangleSurface(4, 5, 6));
        Console.WriteLine("a = 4, b = 6, alfa = 90, s = {0}", TriangleSurfaceWithAngle(3, 6, 90));
    }

    static double TriangleSurface(double a, double h)
    {
        return ((a * h) / 2);
    }

    static double TriangleSurface(double a, double b, double c)
    {
        double p = ((a + b + c) / 2);
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static double TriangleSurfaceWithAngle(double a, double b, int alfa)
    {
        double pi = Math.PI;
        double h = Math.Sin((alfa * pi) / 180);
        return ((a * b * h) / 2);
    }
}
