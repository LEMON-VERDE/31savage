using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    // Collection of functions to MinMax the 31 game card
    static class MinMax31
    {
        public static EvaluatedTurnDecision choose3in4(List<Card> cardsInHand, Card newCard)
        {
            double maxReward = 0;
            int maxIndex = 0;
            List<Card> potentialCards = new List<Card>(cardsInHand);
            potentialCards.Add(newCard);

            if (cardsInHand.Count != Rules31.NB_CARDS_IN_HAND)
                throw new Exception("Incorect number of cards in hand");

            for (int i = 0; i < Rules31.NB_CARDS_IN_HAND; ++i)
            {
                List<Card> selection = potentialCards.Where((card, index) =>
                    index != i).ToList();

                double reward = Rules31.evaluateHand(selection);

                if (reward > maxReward)
                {
                    maxReward = reward;
                    maxIndex = i;
                }
            }

            List<Card> finalSelection = potentialCards.Where((card, index) =>
                    index != maxIndex).ToList();

            Card discarded = potentialCards.ElementAt(maxIndex);

            return new EvaluatedTurnDecision(discarded, TurnDecision.DrawPile.UNKNOWN, finalSelection);
        }
    }
}
