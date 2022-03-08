

namespace AreaCalculator.Parameters
{
    public class TriangleParameter
    {
        public const string Triangle = nameof(Triangle);
        //store three sides of a triangle
        public double A, B, C;
        public TriangleParameter(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

    }
}
