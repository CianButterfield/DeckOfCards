using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a deck
            Deck myDeck = new Deck();
            for (int i = 0; i < myDeck.Contents.Count; i++)
            {
                Console.WriteLine(myDeck.Contents[i].Rank + " of " + myDeck.Contents[i].Suit);
            }
            Console.WriteLine("\n");
            myDeck.Shuffle();
            for (int i = 0; i < myDeck.Contents.Count; i++)
            {
                Console.WriteLine(myDeck.Contents[i].Rank + " of " + myDeck.Contents[i].Suit);
            }

            Console.WriteLine("\n");

            List<Card> myHand = myDeck.Deal(5);
            for (int i = 0; i < myHand.Count; i++)
            {
                Console.WriteLine(myHand[i].Rank + " of " + myHand[i].Suit);
            }
            

            //keep the console open
            Console.ReadKey();
        }
    }
}
