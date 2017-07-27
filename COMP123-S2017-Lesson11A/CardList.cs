using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 27, 2017
 * Description: Abstract superclass CardList
 * Inherits from built-in List generic collection and consumes the Card class
 * Version: 0.1 - Class created
 */
namespace COMP123_S2017_Lesson11A
{
    public abstract class CardList : List<Card>
    {
        //priv instance vars

        //priv props

        //constructor
        public CardList()
        {
            this._initialize();
        }
        //priv methods
        protected abstract void _initialize();
        //pub methods

    }
}