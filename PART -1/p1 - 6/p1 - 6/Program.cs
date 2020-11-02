using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1___6
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = Convert.ToInt32(25.5);
            Console.WriteLine("The first  number is : " +num1);
            float num2 = Convert.ToInt32(3.5);
            Console.WriteLine("The second  number is : " +num2);
            float num3 = Convert.ToInt32(40.5);
            Console.WriteLine("The third  number is : " +num3);
            float num4 = Convert.ToInt32(4.5);
            Console.WriteLine("The Forth  number is : " +num4);

            float result1 = ((num1 * num2 - num2 * num2) / ((num3 - num4)));


            Console.WriteLine("The  solutioin is : " +result1);


            Console.ReadLine();
        }
    }
}
