using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInput
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name");
            String userName = (Console.ReadLine());
            Console.WriteLine("Enter your age");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userName);
            Console.WriteLine(userAge);
            Console.ReadLine();
        }
    }
}
