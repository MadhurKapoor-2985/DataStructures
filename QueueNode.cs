using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class QueueNode
    {
        public string Value {get;set;}
        public QueueNode Next {get;set;}

        public QueueNode(string value)
        {
            Value = value;
            Next = null;
        }
    }
}