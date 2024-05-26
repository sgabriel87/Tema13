using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema13
{
    public class Game
    {
        public Guid Evaluate(List<Player> players)
        {
            var winningPlayer = players.FirstOrDefault(player =>
             {
                 int totalValue = 0;
                 foreach (var card in player.Cards)
                 {
                     totalValue += card.Value;
                 }
                 return totalValue <= 21;
             });
            if (winningPlayer == null)
                return Guid.Empty;

            return winningPlayer.Id;
        }

    }
}
