

namespace AreaCalculator.Parameters
{
    public class UnknownFigure : Figure
    {
        public UnknownFigure(IDictionary<string, object> parameters) : base(parameters)
        {
        }

        protected override double CalculateArea(IDictionary<string, object> param)
        {
            ValidateRequiredParameters(UnknownParameter.Function);

            if (param[UnknownParameter.Function] is Func<IDictionary<string, object>, double> func)
            {
                return func(param);
            }

            throw new InvalidOperationException("parameters is wrong");
        }
    }
}

