namespace CohesionAndCoupling
{
    using System;

    public static class GeometryUtils
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double xDistance = x2 - x1;
            double yDistance = y2 - y1;
            double distance = Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance));
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double xDistance = x2 - x1;
            double yDistance = y2 - y1;
            double zDistance = z2 - z1;
            double distance = Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance) + (zDistance * zDistance));
            return distance;
        }
    }
}
