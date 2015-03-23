

namespace PointProblem
{
    using System;
    using System.Collections.Generic;

    public class TestPoint
    {
        public static void Main(string[] args)
        {
            // test point
            Point3D firstPoint = new Point3D(2, 5, 8);
            Point3D secondPoint = new Point3D(6, 10, 9);

            Console.WriteLine("First point: {0}", firstPoint);
            Console.WriteLine("Second point: {0}", secondPoint);

            //test class distance
            double distance = Distance.CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine("Distance between points: {0: 0.0000}", distance);

            //test path
            Point3D thirdPoint = new Point3D(0, 6, 5);

            Path path = new Path();
            path.AddPoint(firstPoint);
            path.AddPoint(secondPoint);
            path.AddPoint(thirdPoint);

            Console.WriteLine("----Point path----");
            foreach (var point in path.AllPoints)
            {
                Console.WriteLine(point);
            }

            //path.ClearPath();
            //Console.WriteLine(path.GetLenght());

            PathStorage.SavePath(path);

            Path loadedPath = PathStorage.LoadPath();

            Console.WriteLine();

            foreach (var point in loadedPath.AllPoints)
            {
                Console.WriteLine(point);
            }
        }
    }
}
