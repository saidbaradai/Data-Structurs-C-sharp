using System.Collections.Generic;
using System;
using System.IO;

namespace SAIDBARADAI
{

    public class Stack
    {
        private int Index { get; set; }
        private readonly List<object> Elements=new List<object>();

        public void Push(object obj)
        {
            if (obj != null)
            {
                Elements.Add(obj);
                Index++;
            }

            else
                throw new ArgumentNullException("obj", "The obcect Can't be null dude!");

        }


        public int Pop()
        {
            if (Elements.Count != 0)
            {
                Elements.RemoveAt(Index - 1);
                Index--;
            }
            else
                throw new InvalidOperationException("The stak is empty");

            return Index;
        }



        public void Claer()
        {
            Elements.Clear();
            Index = 0;
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(6);
            stack.Push(8);
            stack.Push(8);

            Console.WriteLine("Number of items in stack is : " + stack.Pop());

            stack.Claer();

            stack.Push(8);
            stack.Push(8);
            stack.Push(8);

            Console.WriteLine("Number of items in stack is : "+stack.Pop());

        }




    }
}

