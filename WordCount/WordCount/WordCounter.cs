using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCounter
    {
        private WordCountPair[] collection;
        private readonly int nextFreeLocation = 0;
        public WordCounter(int maxSize)
        {
            collection = new WordCountPair[maxSize];
        }
        public int AddString(String newWord)
        {
            if (nextFreeLocation > collection.Length) return -1;
            int position = 0;
            while ((position < nextFreeLocation) && (string.Compare(newWord, collection[position].GetWord(), StringComparison.Ordinal) > 0))
            {
                position++;
            }
            return 1;
        }
        public override string ToString()
        {
            String theString = "";
            return theString;
        }
    }
}
