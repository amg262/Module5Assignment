using System;
using System.Collections;
using System.Collections.Generic;

namespace Module5Assignment
{
    class Program
    {

        public Stack<string> PreStock(Stack<string> stack)
        {

            if (stack.Count > 0)
            {
                return stack;
            }
            
            var items = new List<string>()
            {
                "Mtn Dew",
                "Human Finger",
                "Cheesecake"
            };

            var localStack = new Stack<string>();
            
            foreach (var item in items)
            {
                localStack.Push(item);
            }
            
            return localStack;
        }

        public void VendingMachine()
        {

            var stack = new Stack<string>();

            Console.WriteLine("VENDING MACHINE");
            this.PreStock(stack);
            
            


        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.VendingMachine();
        }
    }
}