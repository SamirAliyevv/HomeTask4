using System;
using System.Diagnostics.Tracing;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = "Aliyev Samir";
            

            var result = Substring(word); 
            Console.WriteLine( result );



        }

        static string Substring (string str)
        {
            string newStr = "";
            

            for (int i = 0; i < str.Length ; i++)
            {
                if (str[i] != ' ')
                {
                     newStr+= str[i];
                    
                }
                else
                {
                    break;
                }

            } return newStr;    

        }


      
    }
}
