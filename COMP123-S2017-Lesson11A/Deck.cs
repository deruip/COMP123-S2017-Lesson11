using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 25, 2017
 * Description: Deck class. Inherits from CardList superclass
 * Version: 0.6 - Added Deal5 Method
 */
namespace COMP123_S2017_Lesson11A
{
    public class Deck : CardList
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

        //priv methods
        /// <summary>
        /// initializes class variables and list of cards
        /// </summary>
        protected override void _initialize()
        {
            // initialize the random object
            this._random = new Random();

            // load the list with cards
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
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
            outputString += "The deck contains:\n";
            outputString += "=========================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
        /// <summary>
        /// Shuffles the deck
        /// </summary>
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
        /// <summary>
        /// This method removes the card in element 0 from the List and returns it in var firstCard
        /// </summary>
        public Card Deal1()
        {
            Card firstCard = (Card)this[0].Clone();
            this.RemoveAt(0); //removes the top card
            return firstCard;
        }
        /// <summary>
        /// This method returns the top five cards in a new Hand and removes the top five cards from the List
        /// </summary>
        public Hand Deal5()
        {
            Card firstCard = (Card)this[0].Clone();
            Card secondCard = (Card)this[1].Clone();
            Card thirdCard = (Card)this[2].Clone();
            Card fourthCard = (Card)this[3].Clone();
            Card fifthCard = (Card)this[4].Clone();
            this.RemoveRange(0, 5);
            Hand hand = new Hand
            {
                firstCard,
                secondCard,
                thirdCard,
                fourthCard,
                fifthCard
            };
            return hand;
        }
    }
}