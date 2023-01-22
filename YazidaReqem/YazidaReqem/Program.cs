using System;
using System.Reflection.Metadata.Ecma335;

namespace YazidaReqem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Kitab", "Defter2", "Qelem5" };
            char [] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
            Console.WriteLine(StringFindNumber(words,numbers));
        }
     
        
        static int StringFindNumber (string [] words, char[] numbers)
        {
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words [i].Length; j++)
                {
                    for (int d = 0; d < numbers.Length; d++)
                    {
                        if (words[i][j] == numbers[d]) 
                        {

                            count++;    
                        }



                    }



                }



            }

            return count;   
        }






















    }

}
