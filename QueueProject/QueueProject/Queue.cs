using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProject
{
    class Queue
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

        public Queue(int length)
        {
            queue = new string[length];
        }

        public string Remove()
        {
            if (front != back)
            {
                front++;
                return queue[front - 1];
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
            for(int i = front; i < back; i++)
            {
                List = List + queue[i] + ",";                
            }
            return List;
        }
    }
}
