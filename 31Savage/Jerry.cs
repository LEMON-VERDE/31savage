﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    class Jerry : User
    {
        public Jerry(string name, Game game, List<Card> initialCards) : base(name, game)
        {
            this.knownCards = new List<Card>(initialCards);
        }

        public override void playTurn()
        {

        }

        double evaluateHand()
        {
            return 0.0;
        }
    }
}
