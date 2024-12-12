using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class StackNode
    {
        public string Value {get;set;}
        public StackNode Next {get;set;}

        public StackNode(string value)
        {
            Value = value;
            Next = null;
        }
    }
}