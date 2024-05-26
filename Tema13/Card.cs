using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema13
{
    public enum Suit
    {
        Hearts,
        Spades,
        Diamonds,
        Clubs
    }

    public class Card
    {
        public int Value { get; }
        public Suit Suit { get; }

        public Card(int value, Suit suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
