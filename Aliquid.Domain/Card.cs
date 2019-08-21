namespace Aliquid.Domain
{
    using Enums;

    public class Card
    {
        public CardsAttributes Rank { get; set; }
        public CardsAttributes Suit { get; set; }
        
        public CardsAttributes Mask =>  (Rank | Suit);
    }
}