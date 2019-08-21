namespace Aliquid.Application
{
    using System.Collections.Generic;

    public class ChangeCalculator
    {
        private readonly int[] _result;
        private readonly decimal[] _values;

        public ChangeCalculator()
        {
            _result = new int[6];
            _values = new decimal[] {1m, 0.5m, 0.25m, 0.1m, 0.05m, 0.01m};
        }

        public IEnumerable<int> GetChange(decimal money, decimal itemPrice)
        {
            var sum = money - itemPrice;
            
            for (var i = 0; i <= _values.Length - 1; i++)
            {
                sum = Divide(sum, _values[i], _values.Length - i - 1);
            }

            return _result;
        }

        private decimal Divide(decimal sum, decimal value, int pos)
        {
            var division = (int) (sum / value);
            _result[pos] = division;

            return sum - (value * division);
        }
    }
}