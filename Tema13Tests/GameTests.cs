using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tema13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema13.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod]
        public void ReturnWinnerId()
        {
            
            var game = new Game();
            var player1 = new Player("Player1");
            var player2 = new Player("Player2");

            player1.AddCard(new Card(10, Suit.Hearts));
            player1.AddCard(new Card(7, Suit.Spades));
            player2.AddCard(new Card(8, Suit.Hearts));
            player2.AddCard(new Card(9, Suit.Clubs));

            var players = new List<Player> { player1, player2 };
                        
            var winnerId = game.Evaluate(players);
                        
            Assert.AreNotEqual(Guid.Empty, winnerId);
        }

        [TestMethod]
        public void ReturnEmptyGuidIfNoWinner()
        {
            var game = new Game();
            var player1 = new Player("Player1");
            var player2 = new Player("Player2");

            player1.AddCard(new Card(10, Suit.Hearts));
            player1.AddCard(new Card(12, Suit.Diamonds));
            player2.AddCard(new Card(10, Suit.Hearts));
            player2.AddCard(new Card(13, Suit.Spades));

            var players = new List<Player> { player1, player2 };

            var winnerId = game.Evaluate(players);

            
            Assert.AreEqual(Guid.Empty, winnerId);
        }
    }
}