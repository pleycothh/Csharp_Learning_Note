using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.ReadLine();
            
            

        }
    }
}
