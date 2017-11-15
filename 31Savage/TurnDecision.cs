using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    class TurnDecision
    {
        public enum DrawPile
        {
            DISCARD_PILE,
            HIDDEN_PILE,
            UNKNOWN
        };

        Card discarded;
        DrawPile pickedPile;

        public TurnDecision(Card discarded, DrawPile pileChosen)
        {
            this.discarded = discarded;
            this.pickedPile = pileChosen;
        }
    }
}
