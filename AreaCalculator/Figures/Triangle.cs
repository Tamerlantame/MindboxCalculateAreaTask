

using AreaCalculator.Parameters;

namespace AreaCalculator
{
    public class Triangle : Figure
    {
        private readonly IDictionary<string, object> _params;
        public Triangle(IDictionary<string, object> parameters) : base(parameters)
        {
            if (!parameters.Any())
                throw new ArgumentNullException(nameof(parameters));
            _params = parameters;
        }

        protected override double CalculateArea(IDictionary<string, object> param)
        {
            ValidateRequiredParameters(TriangleParameter.Triangle);

            var parameter = GetTriangleParameter(param[TriangleParameter.Triangle]);
            var p = 0.5 * (parameter.A + parameter.B + parameter.C);
            return Math.Sqrt(p * (p - parameter.A) * (p - parameter.B) * (p - parameter.C));
        }
        public bool IsRight
        {
            get
            {
                ValidateRequiredParameters(TriangleParameter.Triangle);

                var parameter = GetTriangleParameter(_params[TriangleParameter.Triangle]);
                var a = parameter.A;
                var b = parameter.B;
                var c = parameter.C;
                return IsPythagorasTriangle(a, b, c) || IsPythagorasTriangle(a, c, b) || IsPythagorasTriangle(c, b, a);

                static bool  IsPythagorasTriangle(double leg1, double leg2, double hypotenuse)
                {
                    return Math.Pow(leg1, 2) + Math.Pow(leg2, 2) == Math.Pow(hypotenuse, 2);
                }
            }
        }
        private TriangleParameter GetTriangleParameter(object parameter)
        {
            if (parameter is TriangleParameter param)
                return param;

            throw new InvalidOperationException($"parameters {nameof(TriangleParameter)} is wrong");
        }
    }
}
