using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1___7
{
    class Program
    {
        static void Main(string[] args)
        {
            float Width = Convert.ToInt32(5.6);
            Console.WriteLine("The first  number is : " + Width);
            float Height = Convert.ToInt32(8.5);
            Console.WriteLine("The second  number is : " + Height);


            float Area = Width * Height;
            float Perimeter = (2 * (Width + Height));
            Console.WriteLine(" Area is : " +Area);
            Console.WriteLine(" Parameter is : " +Perimeter);

            Console.ReadLine();
        }
    }
}
