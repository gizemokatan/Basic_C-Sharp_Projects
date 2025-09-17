using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" ||  answer == "yeah" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();

        }
    }
}














//Main
//                Deck deck = new Deck();
//deck.Shuffle(3);

//foreach (Card card in deck.Cards)
//{
//    Console.WriteLine(card.Face + " of " + card.Suit);
//}
//Console.WriteLine(deck.Cards.Count);
//Console.ReadLine();


//Lambda Expressions
//int counter = 5;
//int count = deck.Cards.Count(x => x.Face == Face.Ace);
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
//int sum = numberList.Where(XmlAtomicValue => XmlAtomicValue > 20).Sum();
//Console.WriteLine(sum);
//foeach (Card card in Deck.Cards)
//    {
//    if (Card.Face == Face.Ace)
//    {
//        counter ==;
//    }
//}
//Console.WriteLine(counter);





//Structs
// int number = 5
//Card card1 = new Card();
//Card card2 = card1;
//card1.Face = Face.Eight;
//card2.Face = Face.King;
//Console.WriteLine(card1.Face);



//enum
//Card card = new Card();
//card.Suit = Suit.Clubs;
//int underlyingValue = Convert.ToInt32(Suit.Diamonds);
//Console.WriteLine(underlyingValue);



//enumExample
//public enum DaysOfTheWeek
//{
//    Monday,
//    Tuesday,
//    Wednasday,
//    Thusday,
//    Friday,
//    Saturday,
//    Sunday
//}


// Operator Overloading
//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Jesse";
//game = game + player;
//game = game - player;



//Game game = new Game();
//game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
//game.ListPlayers();
//Console.ReadLine();



//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
//game.ListPlayers();
//Console.ReadLine();

