namespace Space3D
{

    //Create a class Path to hold a sequence of points in the 3D space.

    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> point = new List<Point3D>();

        public Path()
        {
            this.point = new List<Point3D>();
        }
    }
}
