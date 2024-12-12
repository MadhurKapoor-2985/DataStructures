using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack
    {
        public int Length {get;set;}
        public StackNode Top {get;set;}
        public StackNode Bottom {get;set;}

        public Stack()
        {
            Length = 0;
            Top = null;
            Bottom = null;
        }

        public string Peek() {
            if(!isEmpty()) {
                return Top.Value;
            }
            else {
                return "Stack is empty";
            }
        }

        public string Pop() {
            if(!isEmpty()) {
                var item = Top.Value;
                Top = Top.Next;
                Length--;
                Console.WriteLine($"Popping value - {item}");
                return item;
            }
            Console.WriteLine("Stack is empty");
            return "Stack is empty";
        }

        public void Push(string value) {
            StackNode node = new StackNode(value);

            if(isEmpty()) {
                Top = Bottom = node;
            }
            else {
                node.Next = Top;
                Top = node;
            }
            Length++;
            
        }

        public bool isEmpty() {
            return Length == 0;
        }
    }
}