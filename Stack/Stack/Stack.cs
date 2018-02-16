using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace Stack
{
    public class Stack
    {
        public Stack()
        {
        }

        private readonly List<int> stack = new List<int>();
        private int Stackitem { get; set; }


        public void Push(object obj){
           
            if(obj==null)
                throw new InvalidOperationException("YOu cannot add a null object to the stack");
       
            stack.Add(Stackitem=(int)obj);
        }

        public object Pop()
        {
            
                if (stack.Count != 0)
                {
                    var element = stack.Count - 1;
                    int removed = stack[element];
                    stack.RemoveAt(element);
                    return removed;
                }
            else
                throw new InvalidOperationException("YOu cannot remove from an empty stack");
        }

        public void Clear(){
            if (stack.Count != 0)
            {
                stack.Clear();
                
            }
            else
                throw new InvalidOperationException("The stack is already empty");
            
        }
        }

    }

