using System;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a phrase");
            string text = Console.ReadLine();

            Console.WriteLine($"The number of words is: {CountWordsInAPhrase(text)}");
        }
        private static int CountWordsInAPhrase(string text)
        {
            //1
            //string[] wordArray = text.Split(" ");
            //return wordArray.Length;

            //2
            int wordsCounted = 0;
            int indexstart = 0;
            bool endofText = false;

            while (!endofText)
            {
                int foundAtIndex = text.IndexOf(" ", indexstart, StringComparison.OrdinalIgnoreCase);
                if(text.IndexOf(" ", indexstart, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    wordsCounted++;
                    indexstart = foundAtIndex + 1;
                }
                else
                {
                    endofText = true;
                }
            }
            return wordsCounted;
        }
    }
}
