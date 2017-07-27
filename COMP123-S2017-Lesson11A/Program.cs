﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aron Ly
 * Date: July 25, 2017
 * Description: Demo for Lesson 11
 * Version: 0.4 - Tested Deal5 method of Deck class
 */
namespace COMP123_S2017_Lesson11A
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(); //new empty hand container
            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();

            Console.WriteLine("Testing");
            hand = deck.Deal5(); //creates new Hand object and assigns the top five cards to it
            Console.WriteLine(hand);
            Console.WriteLine("After Dealing:");
            Console.WriteLine(deck.ToString());
        }
    }
}
