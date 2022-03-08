using AreaCalculator.Parameters;


namespace AreaCalculator
{
    public class Circle : Figure
    {
        private const double Pi = Math.PI;
        public Circle(IDictionary<string, object> parameters) : base(parameters)
        {
        }

        protected override double CalculateArea(IDictionary<string, object> parameters)
        {
            ValidateRequiredParameters(CircleParameter.Radius);

            if (parameters[CircleParameter.Radius] is double Radius)
            {
                return Pi * Math.Pow(Radius, 2);
            }

            throw new InvalidOperationException($"parameters {CircleParameter.Radius} is wrong");
        }
    }
}
