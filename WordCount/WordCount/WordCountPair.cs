﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCountPair
    {
        private String word;
        private int count;
        // simple sets and gets for the class
        // SetWord allows a user to set the Word element of Word Count pair
        public void SetWord(String theWord)
        {
            word = theWord;
        }
        // SetCount allows a user to set the Count element of Word Count pair
        public void SetCount(int theCount)
        {
            count = theCount;
        }
        // GetWord allows a user to get the Word element of Word Count pair
        public String GetWord()
        {
            return word;
        }
        // GetCount allows a user to get the Count element of Word Count pair
        public int GetCount()
        {
            return count;
        }
        // CompareTo allows a user to compare a String with WordCount pair
        // useful for ordering
        // passes back -1 if originating string is less, 0 if equal, +1 if greater than parameter
        public int CompareTo(String theWord)
        {
            return word.CompareTo(theWord);
        }
    }
}
