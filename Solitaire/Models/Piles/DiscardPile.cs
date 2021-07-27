using System.Collections.Generic;
using System.Linq;

namespace Solitaire.Models.Piles
{
    public class DiscardPile : PileBase
    {
        public List<Card> GetAll()
        {
            return Cards.ToList();
        }
    }
}