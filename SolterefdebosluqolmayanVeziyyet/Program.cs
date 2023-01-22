using System;

namespace SolterefdebosluqolmayanVeziyyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LeftEmpty("  Samir"));

        }





         static string LeftEmpty (string word)
         {
            string newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                        newWord= newWord + word[i];

                }

            }

            return newWord; 

         }













    }
}
