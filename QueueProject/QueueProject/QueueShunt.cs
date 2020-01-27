using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProject
{
    class QueueShunt
    {
        private string[] queue;
        private int front, back;
        public void Add(string obj)
        {
            if (back < queue.Length)
            {
                queue[back] = obj;
                back++;
            }
        }
        public QueueShunt(int length)
        {
            queue = new string[length];
        }
        public string Remove()
        {
            if (back != 0)
            {
                string found = queue[0];
                for (int i = 0; i < back; i++)
                {
                    queue[i] = queue[i + 1];
                }
                return found;
            }
            return null;
        }
        public int GetLength()
        {
            return back;
        }
        public override string ToString()
        {
            string List = "";
            for (int i = 0; i < back; i++)
            {
                List = List + queue[i] + ",";
            }
            return List;
        }
    }
}
