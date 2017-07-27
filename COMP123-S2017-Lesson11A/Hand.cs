using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 27, 2017
 * Description: Hand Class that inherits from CardList superclass
 * Version: 0.2 - Moved Deal1 method to Deck class
 */
namespace COMP123_S2017_Lesson11A
{
    public class Hand : CardList
    {
        //priv instance vars
        //public props
        //constructors
        //priv methods
        protected override void _initialize()
        {
            throw new NotImplementedException();
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
    }
}