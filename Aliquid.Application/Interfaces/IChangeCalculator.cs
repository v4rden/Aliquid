namespace Aliquid.Application.Interfaces
{
    using System.Collections.Generic;

    public interface IChangeCalculator
    {
        IEnumerable<int> GetChange(decimal money, decimal itemPrice);
    }
}