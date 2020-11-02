using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter the  N  number  : " );
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The N  number is : " +n);
            

            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " +i);
                }
            }

            Console.ReadLine();
        }
          
    }
}
