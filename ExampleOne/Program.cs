using NumberToWordConverter;
using System;

namespace ExampleOne
{
    class Program
    {
        static void Main(string[] args)        
        {

            //Console.WriteLine(NumberToWord.CurrencyFormat(2521.326m, "Dollar", "Cent"));
            //Console.WriteLine(NumberToWord.Convert(1521.326m));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(DateTime.Now.Ticks.ToString());
            }

            Console.ReadLine();
        }
    }
}
