using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 25, 2017
 * Description: Inherits from Card class, This Deck class is a new List type - Card
 * Version: 0.1 - Created the Deck class
 */
namespace COMP123_S2017_Lesson11A
{
    public class Deck : List<Card>
    {
        //priv instance var

        //pub props

        //constructors
        /// <summary>
        /// Main constructor for Deck class
        /// </summary>
        public Deck()
        {
            this._initialize();
        }
        //priv methods
        /// <summary>
        /// Adds new cards to this List
        /// </summary>
        private void _initialize()
        {
            for (int suit = 0; suit < (int)Suit.Spades; suit++)
            {
                for (int face = 1; face < (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }
        //pub methods
        /// <summary>
        /// Overrides ToString and provides a sufficient output
        /// </summary>
        public override string ToString()
        {
            string outputString = "";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }

    }
}