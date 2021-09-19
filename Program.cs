using System;
using System.Collections;
using System.Collections.Generic;

namespace Module5Assignment
{
    class Program
    {
        public List<string> AddStockList()
        {
            var items = new List<string>()
            {
                "Mtn Dew",
                "Human Finger",
                "Cheesecake",
                "Coke",
                "Coke",
                "King of the Hill DVD Boxset",
                "The car for Night Rider",
                "GameBoy Color your grandma bought you for your 7th b-day",
                "A box for Forrest Gump flavored chocolates"
            };

            return items;
        }

        public Stack<string> PreStock(Stack<string> stack)
        {
            if (stack.Count > 0)
            {
                return stack;
            }

            var items = this.AddStockList();

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
            bool isDone = false;
            Console.WriteLine("VENDING MACHINE");
            var local = this.PreStock(stack);

            while (local.Count > 0 && isDone == false)
            {
                Console.Write("A. -> Add  |  B. -> Buy  |  O. -> Output  |  E. -> End");
                char action = Console.ReadLine().ToLower()[0];

                switch (action)
                {
                    case 'a':
                        Random rnd = new Random();
                        int value = rnd.Next(1, 7);
                        var addItem = this.AddStockList();
                        local.Push(addItem[value]);
                        Console.Write(value);

                        break;
                    case 'b':
                        if (local.Count > 0)
                        {
                            string index = local.Pop();
                            Console.WriteLine($"You bought {index}.");
                        }
                        else
                        {
                            Console.WriteLine("Thank you for vending!");
                            isDone = true;
                        }

                        break;
                    case 'o':

                        Console.Write($"{local.Count} items stocked.\n");
                        foreach (var item in local)
                        {
                            Console.Write($"{item}\n");
                        }

                        break;
                    case 'e':
                        Console.WriteLine("Thank you for vending!");
                        isDone = true;
                        break;
                    default:
                        Console.WriteLine("Thank you for vending!");
                        isDone = true;
                        break;
                }
            }
            Console.WriteLine("Thank you for vending!");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.VendingMachine();
        }
    }
}