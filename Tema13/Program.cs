using Tema13;

var player1 = new Player("Alice");
player1.AddCard(new Card(10, Suit.Hearts)); 
player1.AddCard(new Card(7, Suit.Spades)); 
var player2 = new Player("Bob");
player2.AddCard(new Card(8, Suit.Hearts)); 
player2.AddCard(new Card(9, Suit.Clubs)); 

var game = new Game();
var players = new List<Player> { player1, player2 };

var winnerId = game.Evaluate(players);
if (winnerId != Guid.Empty)
{
    Console.WriteLine($"Player {players.Find(p => p.Id == winnerId).Name} wins!");
}
else
{
    Console.WriteLine("No winner.");
}


var player3 = new Player("Charlie");
player3.AddCard(new Card(10, Suit.Hearts));
player3.AddCard(new Card(10, Suit.Spades));
var player4 = new Player("David");
player4.AddCard(new Card(10, Suit.Diamonds));
player4.AddCard(new Card(10, Suit.Clubs));

players = new List<Player> { player3, player4 };

winnerId = game.Evaluate(players);
if (winnerId != Guid.Empty)
{
    if (players.All(p => p.Cards.Sum(c => c.Value) == players[0].Cards.Sum(c => c.Value)))
    {
        Console.WriteLine("It's a draw!");
    }
    else
    {
        var winner = players.OrderByDescending(p => p.Cards.Sum(c => c.Value)).FirstOrDefault();
        Console.WriteLine($"Player {winner.Name} wins!");
    }
}
