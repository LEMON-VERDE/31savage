using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    class Game
    {
        public int round;
        public int cardsInDrawPile = 52;
        public Stack<Card> throwAwayPile;
        public List<User> players;
        private User currentPlayer;
        private User playerWhoKnocked;

        public void setCurrentPlayer(User player) { currentPlayer = player; }
        public User getCurrentPlayer(){ return currentPlayer; }
        public void setPlayerWhoKnocked(User player) { playerWhoKnocked = player; }
        public User getPlayerWhoKnocked() { return playerWhoKnocked; }

        public Card getLastThrownCard() { return throwAwayPile.Pop(); }
        public Card checkLastThrownCard() { return throwAwayPile.Peek(); }
        public void throwACard(Card card) { throwAwayPile.Push(card); }
    }
}
