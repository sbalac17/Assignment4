using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Shivya Balachandran
    Comp123
    07/19/2016
    300884989
*/
namespace DiceRollingSimulations
{  /**
    * <summary>
    * This class is the main program
    * </summary>
    * 
    * @class Program
    */
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] tally = new int[13];
            // simulate 36000 two dice rolls
            for (int i = 0; i < 36000; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;
                tally[sum]++;
            }
            // show the results 
            Console.WriteLine("{0,-8} | {1,-8}", "Sum", "Count");
            Console.WriteLine("---------------------");

            for (int i = 2; i < tally.Length; i++)
            {
                Console.WriteLine("{0,-8} | {1,-8}", i, tally[i]);

            }

        }
    }
}
