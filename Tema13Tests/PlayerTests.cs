using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tema13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Tema13.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void ShouldAddCard()
        {

            var player = new Player("TestPlayer");
           
            var card = new Mock<Card>(10, Suit.Hearts);
            
            player.AddCard(card.Object);
            
            Assert.IsTrue(player.Cards.Contains(card.Object));
        }

        [TestMethod()]
        public void GetDescription()
        {

            var player = new Player("TestPlayer");
                        
            var mockCard1 = new Mock<Card>(10, Suit.Hearts);
            mockCard1.Setup(c => c.ToString()).Returns("10 of Hearts");
            var mockCard2 = new Mock<Card>(5, Suit.Spades);
            mockCard2.Setup(c => c.ToString()).Returns("5 of Spades");

            player.AddCard(mockCard1.Object);
            player.AddCard(mockCard2.Object);
                        
            var description = player.GetDescription();
                        
            StringAssert.Contains(description, player.Id.ToString());
            StringAssert.Contains(description, player.Name);
            StringAssert.Contains(description, "10 of Hearts");
            StringAssert.Contains(description, "5 of Spades");
        }
    }
}