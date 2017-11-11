using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    class Card
    {
        public enum Suit
        {
            HEART,
            CLUB,
            DIAMOND,
            SPADE
        }

        public enum Rank
        {
            ACE,
            TWO,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK,
            QUEEN,
            KING
        }

        public Rank rank;
        public Suit suit;

        Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }


    }
}
