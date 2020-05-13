using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem();
            problem.Problem1();

            problem.Problem2();

            problem.Problem3();

            Console.WriteLine("Please enter a word: ");
            string userInput = Console.ReadLine();
            string programOutput = problem.Problem4(userInput);
            Console.WriteLine(programOutput);
            Console.ReadLine();
        }
    }
}
