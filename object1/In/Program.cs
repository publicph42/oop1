using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3D v1 = new Vector3D(3, 4, 5);
            Vector3D v2 = new Vector3D(6, 8, 10);

            double distance = CalculateDistance(in v1, in v2);
        }

        static double CalculateDistance(in Vector3D start, in Vector3D end)
        {
            double dx = end.X - start.X; 
            double dy = end.Y - start.Y; 
            double dz = end.Z - start.Z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        struct Vector3D
        {
            public double X, Y, Z;
            ////////
            /// The below is a constructor
            /// We have an object and we have a method named the same as the object
            /// This method will run once when the object is created and never again
            /// This is called a "constructor"
            public Vector3D(double x, double y, double z)
            {
                X = x; Y = y; Z = z;
            }
        }

    }
}
