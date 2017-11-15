using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Savage
{
    class Game
    {
        public int round = 0;
        public int cardsInDrawPile = 52;
        public Stack<Card> throwAwayPile;
        public List<User> players;
        private User currentPlayer;
        private User playerWhoKnocked = null;
        List<User>.Enumerator listIterator;

        //Game

        //List of players
        private void initPlayersIterator() {    listIterator = players.GetEnumerator();
                                                listIterator.MoveNext();}
        public User nextPlayer() {
            if (listIterator.MoveNext())
                return listIterator.Current;
            else{
                initPlayersIterator();
                return listIterator.Current;
            }
        }
        //Player
        public User getCurrentPlayer() { return listIterator.Current; }

        //Card
        public Card getLastThrownCard() { return throwAwayPile.Pop(); }
        public Card checkLastThrownCard() { return throwAwayPile.Peek(); }
        public void throwACard(Card card) { throwAwayPile.Push(card); }

    }
}
