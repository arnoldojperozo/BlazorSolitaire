using Solitaire.Models.Common.Enums;

namespace Solitaire.Models.Piles
{
    public class SuitPile : PileBase
    {
        public CardSuit Suit { get; set; }

        public SuitPile(CardSuit suit)
        {
            Suit = suit;
        }

        public CardValue AllowedValue
        {
            get
            {
                var topCard = Last();
                if (topCard == null) return CardValue.Ace;

                var currentValue = (int) topCard.Value;
                return (CardValue) (currentValue + 1);
            }
        }

        public bool IsComplete => (int) AllowedValue == 14;
    }
}