using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    class User
    {
        public string name;
        public Game game;
        public List<Card> knownCards;

        public User(string name, Game game)
        {
            this.name = name;
            this.knownCards = new List<Card>();
        }

        public virtual TurnDecision playTurn ()
        {
            // Ask through the GUI which pile was drawn from

            // Ask through the GUI which card was thrown

            // Modify Game attributes according to user inputs

            return new TurnDecision(null, TurnDecision.DrawPile.UNKNOWN);
        }
    }
}
