namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileNameParser.GetFileExtension("example"));
            Console.WriteLine(FileNameParser.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameParser.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameParser.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameParser.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameParser.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", GeometryUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", GeometryUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Cuboid cube = new Cuboid(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", cube.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", cube.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", cube.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", cube.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", cube.CalcDiagonalYZ());
        }
    }
}
