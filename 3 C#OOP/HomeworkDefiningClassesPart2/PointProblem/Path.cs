namespace PointProblem
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        public List<Point3D> AllPoints = new List<Point3D>();

        public void AddPoint(Point3D point) 
        {
            this.AllPoints.Add(point);
        }

        public void ClearPath()
        {
            this.AllPoints.Clear();
        }

        public int GetLenght()
        {
            return this.AllPoints.Count;
        }
    }
}
