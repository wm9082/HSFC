using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BusTimetable.Properties;

namespace BusTimetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            string fileContent = Resources.Data;
            StringReader reader = new StringReader(fileContent);
            String[] theDictionary = new String[100];
            int nextFreeLocation = 0;
            while ((line = reader.ReadLine()) != null)
            {
                theDictionary[nextFreeLocation] = line;
                nextFreeLocation++;
            }
            Console.ReadLine();
        }
    }
}
