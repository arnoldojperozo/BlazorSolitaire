using System.Collections.Generic;

namespace Solitaire.Models
{
    public class CardDeck
    {
        protected Stack<Card> Cards { get; set; } = new Stack<Card>();

        public Card Draw()
        {
            var card = Cards.Pop();
            card.IsVisible = true;
            return card;
        }
        
        public Card DrawHidden()
        {
            var card = Cards.Pop();
            card.IsVisible = false;
            return card;
        }
        
        public void Add(Card card)
        {
            Cards.Push(card);
        }
    }
}