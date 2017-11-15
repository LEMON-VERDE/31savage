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
            SPADE,
            UNDEFINED
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

        public override string ToString()
        {
            return base.ToString();
        }

        public int getWorth()
        {
            switch (this.rank)
            { 
                case Rank.TEN:
                case Rank.JACK:
                case Rank.QUEEN:
                case Rank.KING:
                    return 10;
                case Rank.ACE:
                    return 11;
                case Rank.TWO:
                    return 2;
                case Rank.THREE:
                    return 3;
                case Rank.FOUR:
                    return 4;
                case Rank.FIVE:
                    return 5;
                case Rank.SIX:
                    return 6;
                case Rank.SEVEN:
                    return 7;
                case Rank.EIGHT:
                    return 8;
                case Rank.NINE:
                    return 9;
            }
            return 0;
        }
    }
}
