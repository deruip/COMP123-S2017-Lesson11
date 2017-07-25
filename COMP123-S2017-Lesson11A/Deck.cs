using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 25, 2017
 * Description: Inherits from Card class, This Deck class is a new List type - Card
 * Version: 0.2 - Added public Shuffle method
 */
namespace COMP123_S2017_Lesson11A
{
    public class Deck : List<Card>
    {
        //priv instance var
        private Random _random;

        //priv props
        private Random Random
        {
            get
            {
                return this._random;
            }
        }
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
        /// initializes class variables and list of cards
        /// </summary>
        private void _initialize()
        {
            //initialize the random object
            this._random = new Random();

            //loads list with cards
            for (int suit = 0; suit < (int)Suit.Spades; suit++)
            {
                for (int face = 1; face <= (int)Face.King; face++)
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
        
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int i = 0; i < this.Count; i++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }
    }
}