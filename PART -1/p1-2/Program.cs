using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first  number is : " + num1);
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second  number is : " + num2);

            int result = num1 + num2;

            Console.WriteLine("addition is : " + result);


            Console.ReadLine(); 
        }
    }
}
