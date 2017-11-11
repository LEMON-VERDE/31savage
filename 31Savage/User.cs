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
        public List<Card> knownCards;

        public User(string name)
        {
            this.name = name;
            this.knownCards = new List<Card>();
        }


        public void playTurn (Game game)
        {
            // Ask through the GUI which pile was drawn from

            // Ask through the GUI which card was thrown

        }
    }
}
