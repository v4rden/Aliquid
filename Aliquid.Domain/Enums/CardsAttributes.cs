namespace Aliquid.Domain.Enums
{
    using System;

    [Flags]
    public enum CardsAttributes
    {
        Two = 0,
        Three = 1,
        Four = 2,
        Five = 4,
        Six = 8,
        Seven = 16,
        Eight = 32,
        Nine = 64,
        Ten = 128,
        J = 256,
        Q = 512,
        K = 1024,
        A = 2048,
        Club = 4096,
        Diamond = 8192,
        Heart = 16384,
        Spade = 32768
    }
}