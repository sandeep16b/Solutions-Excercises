using System;
using System.Threading;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            stack.Push(0);
            //clears one element pushed above, which is '0'
            stack.Clear();
            Console.WriteLine("Nothing left to Pop, Will throw an exception in 3 seconds");
            Thread.Sleep(3000);

            Console.WriteLine(stack.Pop());

        }
    }
}
