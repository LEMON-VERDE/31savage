using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    class EvaluatedTurnDecision : TurnDecision
    {

        public EvaluatedTurnDecision(Card discarded, DrawPile pileChosen) : base(discarded, pileChosen)
        {

        }
    }
}
