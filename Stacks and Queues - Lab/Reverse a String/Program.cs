using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splited = input.Split(' ');
            Stack<string> stack = new Stack<string>();
            foreach(var word in splited)
            {
                stack.Push(word);
            }
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
