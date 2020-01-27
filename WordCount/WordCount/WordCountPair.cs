using System;
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
        public void SetWord(String theWord)
        {
            word = theWord;
        }
        public void SetCount(int theCount)
        {
            count = theCount;
        }
        public String GetWord()
        {
            return word;
        }
        public int GetCount()
        {
            return count;
        }
        public int CompareTo(String theWord)
        {
            return word.CompareTo(theWord);
        }
    }
}
