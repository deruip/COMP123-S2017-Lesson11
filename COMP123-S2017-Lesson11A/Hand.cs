using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 27, 2017
 * Description: Hand Class that inherits from CardList superclass
 * Version: 0.5 - Added HighestCards method
 */
namespace COMP123_S2017_Lesson11A
{
    public class Hand : CardList
    {
        //priv instance vars
        //public props
        //constructors
        //priv methods
        /// <summary>
        /// Initializes class variables
        /// </summary>
        protected override void _initialize()
        {
            //this method is currently empty
        }
        //pub methods

        /// <summary>
        /// This method overrides built-in ToString method
        /// </summary>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The hand contains:\n";
            outputString += "=========================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
        /// <summary>
        /// This method uses LINQ to show the card(s) with the highest face value
        /// </summary>
        public void HighestCards()
        {
            var Highest =
                from Card in this
                orderby Card.Face descending
                select Card.Face;

            Console.WriteLine("The cards with the greatest face value:");
            Console.WriteLine("=========================================================");
            foreach (var item in this)
            {
                if (item.Face == Highest.First())
                {
                    Console.WriteLine($"{item.Face} of {item.Suit}");
                }
            }
        }
    }
}