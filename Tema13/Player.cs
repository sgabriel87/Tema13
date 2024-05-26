using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema13
{
    public class Player
    {
        public Guid Id { get; }
        public string Name { get; }
        public List<Card> Cards { get; }

        public Player(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public string GetDescription()
        {
            return $"Player ID: {Id}, Name: {Name}, Cards: {string.Join(", ", Cards)}";
        }
    }
}