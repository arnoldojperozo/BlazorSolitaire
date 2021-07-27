using System.Collections.Generic;
using System.Linq;

namespace Solitaire.Models.Piles
{
    public class StackPile : PileBase
    {
        public List<Card> GetAllCards()
        {
            return Cards;
        }

        public int Count()
        {
            return Cards.Count;
        }

        public bool HasNoHiddenCards()
        {
            return Any() || Cards.All(x => x.IsVisible);
        }

        public int IndexOf(Card card)
        {
            var matchingCard = Cards.FirstOrDefault(x => x.Suit == card.Suit && x.Value == card.Value);

            if (matchingCard != null)
                return Cards.IndexOf(matchingCard);

            return 0;
        }
    }
}