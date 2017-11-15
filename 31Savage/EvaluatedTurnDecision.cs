using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    class EvaluatedTurnDecision : TurnDecision
    {
        List<Card> cardsChosen;
        double worthAfterTurn;

        public EvaluatedTurnDecision(Card discarded, DrawPile pileChosen, List<Card> cardsChosen) : base(discarded, pileChosen)
        {
            this.cardsChosen = cardsChosen;
            worthAfterTurn = Rules31.evaluateHand(cardsChosen);
        }
    }
}
