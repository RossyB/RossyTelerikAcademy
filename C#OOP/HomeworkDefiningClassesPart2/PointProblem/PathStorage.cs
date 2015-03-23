using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PointProblem
{
    public class PathStorage
    {
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../PathSaves.txt"))
            {

                StringBuilder result = new StringBuilder();
                foreach (var point in path.AllPoints)
                {
                    result.AppendLine(point.X.ToString());
                    result.AppendLine(point.Y.ToString());
                    result.AppendLine(point.Z.ToString());
                }
                writer.WriteLine(result);
            }
        }

        public static Path LoadPath()
        {
            Path loadPath = new Path();
            using (StreamReader reader = new StreamReader(@"../../PathSaves.txt"))
            {
                Point3D point = new Point3D();
                string line = reader.ReadLine();
                do
                {
                    point.X = int.Parse(line);
                    line = reader.ReadLine();
                    point.Y = int.Parse(line);
                    line = reader.ReadLine();
                    point.Z = int.Parse(line);
                    loadPath.AddPoint(point);

                    line = reader.ReadLine();

                } while (line.Trim() == null);
            }
            return loadPath;
        }
    }
}
