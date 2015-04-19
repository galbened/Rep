using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            for (; ; )
            {
                Console.WriteLine("Welcome to GIT.");
                input = Console.ReadLine();
                if (input.Equals("q"))
                    break;
            }
        }
    }
}
