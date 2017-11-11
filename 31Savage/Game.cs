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
        private List<User>.Enumerator listIterator;
        private bool hasSetListIterator = false;

        //Game
        public void initGame() { }

        //List of players
        private void setListIterator() { listIterator = players.GetEnumerator();
                                        listIterator.MoveNext();}
        public void initListIterator() { if (!hasSetListIterator) { setListIterator();
                                                                     hasSetListIterator = true;} }

        //Player
        public void setCurrentPlayer(User player) { currentPlayer = player; }
        public User getCurrentPlayer(){ return currentPlayer; }
        public void setPlayerWhoKnocked(User player) { playerWhoKnocked = player; }
        public User getPlayerWhoKnocked() { return playerWhoKnocked; }

        //public void currentPlayerPlayed() { setCurrentPlayer(players) }

        //Card
        public Card getLastThrownCard() { return throwAwayPile.Pop(); }
        public Card checkLastThrownCard() { return throwAwayPile.Peek(); }
        public void throwACard(Card card) { throwAwayPile.Push(card); }

        //Rounds and turns
        //public bool isGameDone() { if (getCurrentPlayer() == getPlayerWhoKnocked() ||
       //                                                                             )
        //                            { return true; } }
    }
}
