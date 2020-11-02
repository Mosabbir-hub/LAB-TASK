using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i , sum = 0 ;

            // Reading number
           

            for (i = 2; i <= 100; i += 2)
            {
                //Adding current even number to sum variable
                sum += i;
            }
            Console.WriteLine("Sum of all even number between 1 to 100 is: " + sum);

            Console.ReadLine();

           
            // Reading number
            

            for (i = 1; i <= 100; i += 2)
            {
                //Adding current even number to sum variable
                sum += i;
            }
            Console.WriteLine("Sum of all odd number between 1 to 100 is:" + sum);

            Console.ReadLine();
        }
    }
}
