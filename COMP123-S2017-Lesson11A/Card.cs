using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 25, 2017
 * Description: Card class for card shuffling and dealing simulation
 * Version: 0.1 - Created the Card class
 */
namespace COMP123_S2017_Lesson11A
{
    public class Card
    {
        //private instance variables
        private Face _face;
        private Suit _suit;

        //public props
        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }
        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }
        //constructors
        /// <summary>
        /// Main constructor
        /// Two parameters: face (Face) - suit (Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        //private methods


        //public methods


    }
}