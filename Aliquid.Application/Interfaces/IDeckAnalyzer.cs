namespace Aliquid.Application.Interfaces
{
    using System.Collections.Generic;

    public interface IDeckAnalyzer
    {
        int GetFullDecksAmount(ICollection<string> pile);
    }
}