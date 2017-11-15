using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    class Rules31
    {
        static double evaluateHand(List<Card> cardsToEval)
        {
            double max = 0;
            double sum = 0;
            Card.Suit type = Card.Suit.UNDEFINED;
            bool allCardsSameType = true;

            foreach (Card iCard in cardsToEval)
            {
                if (iCard.getWorth() > max)
                {
                    max = iCard.getWorth();
                }

                sum += iCard.getWorth();

                if (iCard.suit == Card.Suit.UNDEFINED)
                    throw new Exception("Cannot evaluate a hand containing a hand with a card of undefined suit");

                if (type == Card.Suit.UNDEFINED)
                    type = iCard.suit;
                else if (type != iCard.suit)
                    allCardsSameType = false;
            }

            if (allCardsSameType)
                return sum;
            // else
            return max;
        }
    }
}
