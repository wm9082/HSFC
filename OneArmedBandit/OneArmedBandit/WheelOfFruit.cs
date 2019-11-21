using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneArmedBandit
{
    public class WheelOfFruit
    {
        private Random random = new Random();

        public enum Fruits { Apple, Banana, Bar, Grape, Orange, Pear, Raspberry, Strawberry }
        private Fruits[] theWheel = new Fruits[8];
        private const int viewPos = 4;

        public WheelOfFruit()
        { 
            for (int i = 0; i < theWheel.Length; i++)
            {
                theWheel[i] = (Fruits)i;
            }
            shuffle();
        }

        private void shuffle()
        {
            int first, second;
            Fruits temp;

            for (first = 0; first < theWheel.Length; first++)
            {
                second = random.Next(0, theWheel.Length); 

                temp = theWheel[first];
                theWheel[first] = theWheel[second];
                theWheel[second] = temp;

            }
        }

        public void spin(int num)
        {
            Fruits front;

            for (int notch = 0; notch < num; notch++)
            {
                front = theWheel[0];
                for (int i = 0; i < theWheel.Length - 1; i++)
                {
                    theWheel[i] = theWheel[i + 1];
                }
                theWheel[theWheel.Length - 1] = front;
            }
        }

        public Fruits getCurrentFruit()
        {
            return theWheel[viewPos]; 
        }
    }
}