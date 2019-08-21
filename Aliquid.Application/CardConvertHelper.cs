namespace Aliquid.Application
{
    using System;
    using Domain.Enums;

    public static class CardConvertHelper
    {
        public static CardsAttributes GetSuit(char s)
        {
            switch (s)
            {
                case 'c':
                    return CardsAttributes.Club;
                case 'd':
                    return CardsAttributes.Diamond;
                case 'h':
                    return CardsAttributes.Heart;
                case 's':
                    return CardsAttributes.Spade;
            }

            throw new ArgumentException($"Can not convert {s} to suit");
        }

        public static CardsAttributes GetRank(char r)
        {
            switch (r)
            {
                case '2':
                    return CardsAttributes.Two;
                case '3':
                    return CardsAttributes.Three;
                case '4':
                    return CardsAttributes.Four;
                case '5':
                    return CardsAttributes.Five;
                case '6':
                    return CardsAttributes.Six;
                case '7':
                    return CardsAttributes.Seven;
                case '8':
                    return CardsAttributes.Eight;
                case '9':
                    return CardsAttributes.Nine;
                case 't':
                    return CardsAttributes.Ten;
                case 'j':
                    return CardsAttributes.J;
                case 'q':
                    return CardsAttributes.Q;
                case 'k':
                    return CardsAttributes.K;
                case 'a':
                    return CardsAttributes.A;
            }
            
            throw new ArgumentException($"Can not convert {r} to rank");
        }
    }
}