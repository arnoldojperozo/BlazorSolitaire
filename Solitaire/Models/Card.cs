using Solitaire.Models.Common.Enums;

namespace Solitaire.Models
{
    public class Card
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
        public string ImageName { get; set; }
        public bool IsVisible { get; set; }

        public bool IsRed => Suit == CardSuit.Diamonds || Suit == CardSuit.Hearts;
        public bool IsBlack => !IsRed;
    }
}