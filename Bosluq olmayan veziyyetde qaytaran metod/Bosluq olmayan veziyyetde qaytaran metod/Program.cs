using System;

namespace Bosluq_olmayan_veziyyetde_qaytaran_metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "    Kitab";
            Console.WriteLine(Index(word));
            
        }

        static string Index(string word)
        {
            string newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]!=' ')
                {

                    newWord += word[i]; 

                }

            }  return newWord;

        }




    }
}
