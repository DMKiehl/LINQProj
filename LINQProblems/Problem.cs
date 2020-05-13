using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problem
    {
        //member variables

        //constructor

        //member methods

            //Problem 1
        public void Problem1()
        {
            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var getWords = words.Where(w => w.Contains("th"));

            foreach (var word in getWords)
            {
                Console.WriteLine(word);
            }

        }

         //Problem 2

        public void Problem2()
        {
            var names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var getNames = names.Distinct();

            foreach (var name in getNames)
            {
                Console.WriteLine(name);
            }

        }

        //Problem 3
        public void Problem3()
        {
            double averageNum = 0;
            var classGrades = new List<string> { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            int count = classGrades.Count();

            foreach (var studentGrades in classGrades)
            {
                double[] grades = studentGrades.Split(',').Select(g => Convert.ToDouble(g)).OrderByDescending(g => g).ToArray();
                grades = grades.Take(grades.Length - 1).ToArray();
                double average = grades.Average();
                averageNum += average;
        
                
            }


            double finalNumber = averageNum / count;
            Console.WriteLine(finalNumber);
        }


        //Problem 4
        public string Problem4(string userInput)
        {
            var letterCount = "";
            string newWord = userInput.ToLower();
            var result = newWord.Distinct().OrderBy(a => a);

            foreach (var item in result)
            {
                var newResult = newWord.Count(u => u == item);
                letterCount += Char.ToString(item) + newResult;
            }
           
            return letterCount;


        }

    }

}
