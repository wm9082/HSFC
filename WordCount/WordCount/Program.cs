using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemWordCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your poem:");
            WordCounter dictionary = new WordCounter(100);
            string[] poem = Console.ReadLine().Split(" ");
            // I should read in line of text
            // process line of text, looking for individual words
            // for each word for WordCounter AddString
            // start with just a word at a time :-)
            for (int i = 0; i < poem.Length; i++)
            {
                dictionary.AddWordToList(poem[i]);
            }
            for (int i = 0; i < dictionary.GetNextFreeeLocation(); i++)
            {
                Console.WriteLine(dictionary.GetList()[i].GetWord() + " - " + dictionary.GetList()[i].GetCount());
            }
            Console.ReadLine();
        }
    }
}