namespace PointProblem
{
    using System;
    using System.Text;

    public struct Point3D
    {
        public static readonly Point3D zero = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Point ({0}, {1}, {2})", this.X, this.Y, this.Z);
            return result.ToString();
        }
    }
}
