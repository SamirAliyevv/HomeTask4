using System;

using System;

namespace Array___Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod.Misalçün verilmiş arraydə { 4, -3, 10, -24}
            //dəyərləridirsə methoddan geriyə { 4, 10}
            //dəyərli array qayıdır.
            int[] numbers = { 1, 2, -3, -5, 7 };
            PositiveNumber(numbers);





        }

        static void PositiveNumber(int[] numbers)
        {
            foreach( int eded in numbers)
            {

                if (eded>0)
                {
                    Console.WriteLine(eded);
                }

            }
        }









      

   
        


    }
}
