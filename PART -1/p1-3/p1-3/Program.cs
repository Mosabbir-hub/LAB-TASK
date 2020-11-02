using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
           

            int result1 = num1 + num2;
            int result2 = num1 - num2;
            int result3 = num1 * num2;
            int result4 = num1 / num2;
            int result5 = num1 % num2;

            Console.WriteLine("addition is : " + result1);
            Console.WriteLine("Substruction  is : " + result2);
            Console.WriteLine("multiplication is : " + result3);
            Console.WriteLine("devesion is  : " + result4);
            Console.WriteLine("reminder  is  : " + result5);

            Console.ReadLine();
        }
    }
}
