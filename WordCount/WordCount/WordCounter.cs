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
        // constructor takes a parameter to specify how big the array should be
        public WordCounter(int maxSize)
        {
            collection = new WordCountPair[maxSize];
        }
        // AddWord takes in a new word, adds it to the collection and returns current count for that word
        // Passes back -1 if it can't be added
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
            //  go through array, and for each entry add Word,Count and newline to String
            return theString;
        }
    }
}
