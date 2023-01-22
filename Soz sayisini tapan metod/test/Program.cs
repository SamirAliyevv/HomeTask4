using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Soz daxil edin");
            string str= Console.ReadLine();
            int wc = 1;
            Console.WriteLine(WordsCount( str, wc));

            

        }
        static int WordsCount(string str, int wc)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ')
                {
                    wc++;

                }


            }  return wc;
            

            

        }

         

    }
}
      