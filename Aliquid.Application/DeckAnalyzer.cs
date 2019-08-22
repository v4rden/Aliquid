namespace Aliquid.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Domain;
    using Interfaces;

    public class DeckAnalyzer : IDeckAnalyzer
    {
        private readonly List<Card> _pileOfCards;

        public DeckAnalyzer()
        {
            _pileOfCards = new List<Card>();
        }
        
        public int GetFullDecksAmount(ICollection<string> pile)
        {
            if (pile.Count < 52)
                return 0;
            
            Convert(pile);

            return CalculateFullDecks();
        }

        private int CalculateFullDecks()
        {
            var groupedCards = _pileOfCards
                .GroupBy(card => card.Mask)
                .Select(g => new {Value = g.Key, Count = g.Count()});
            return groupedCards.Min(x => x.Count);
        }

        private void Convert(ICollection<string> pile)
        {
            if (pile.Count < 52)
                return;
            foreach (var acronym in pile)
            {
                _pileOfCards.Add(GetCard(acronym));
            }
        }

        private static Card GetCard(string acronym)
        {
            return new Card
            {
                Rank = CardConvertHelper.GetRank(Char.ToLower(acronym[0])),
                Suit = CardConvertHelper.GetSuit(Char.ToLower(acronym[1]))
            };
        }
    }
}