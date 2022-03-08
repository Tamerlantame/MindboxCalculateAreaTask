

namespace AreaCalculator
{
    public abstract class Figure
    {
        // to store the parameters of a specific figure
        private readonly IDictionary<string, object> _params;

        protected Figure(IDictionary<string, object> parameters)
        {
            if (!parameters.Any())
                throw new ArgumentNullException(nameof(parameters));
            _params = parameters;
        }
        public double OnCalculate()
        {
            return CalculateArea(_params);
        }

        protected void ValidateRequiredParameters(params string[] parameterNames)
        {
            foreach (var name in parameterNames)
            {
                if (!_params.TryGetValue(name, out var value))
                    throw new InvalidOperationException($"Not found required parameter #{name}");

                if (value == null)
                    throw new ArgumentNullException($"argument #{name} can not be null");
            }
        }

        protected abstract double CalculateArea(IDictionary<string, object> param);

    }
}