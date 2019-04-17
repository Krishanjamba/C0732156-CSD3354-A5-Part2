using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732156_CSD3354_A5_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("The Longest Word is : ");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }

        public void MyFunctionA(string input)
        {
            string[] words = input.Split('');

            int wordArrayLength = words.Length;
            int[] wordsLenth = new int[wordArrayLength];
            int x = 0;

            foreach (var word in words)
            {

            }
            string currentWord = words[0];
            string nextWord;
            string longestWord = currentWord;

            for (int y = 0; y <words.Length - 1; y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];

            }
        }
    }
}
        