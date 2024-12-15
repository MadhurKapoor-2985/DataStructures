using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Queue
    {
        public QueueNode First {get;set;}
        public QueueNode Last {get;set;}
        public string Value {get;set;}

        public int Length {get;set;}

        public Queue()
        {
            First = Last = null;
            Length = 0;
        }

        public string Enqueue(string value) {
            var node = new QueueNode(value);
            if(Length == 0) {
                First = Last = node;
                Length++;
                return node.Value;
            }
            Length++;
            Last.Next = node;
            Last = node;
            return node.Value;

        }

        public string Dequeye() {
            if((Length != 0)) {
                Console.WriteLine($"Dequeue Item - {First.Value}");
                First = First.Next;
                Length--;
            }

            return "Empty";
        }
    }
}