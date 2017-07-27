using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aron Ly
 * Date: July 25, 2017
 * Description: Demo for Lesson 11
 * Version: 0.5 - Implemented testing of HighestCards method
 */
namespace COMP123_S2017_Lesson11A
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(); //new empty hand container
            Deck deck = new Deck();
            deck.Shuffle();
            Console.WriteLine("Before Dealing:");
            Console.WriteLine(deck);
            Console.WriteLine();

            Console.WriteLine("Testing Deal5 Method:");
            hand = deck.Deal5(); //assigns top five cards of deck to hand object
            Console.WriteLine(hand);
            Console.WriteLine("After Dealing:");
            Console.WriteLine(deck);

            Console.WriteLine("Testing HighestCards method:");
            Console.WriteLine(hand);
            hand.HighestCards();
        }
    }
}
