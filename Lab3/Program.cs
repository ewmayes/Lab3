using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        
            
        static void Main(string[] args)
        {
            string Response = "";
            do
            {
                // Input
                Console.Clear();
                Console.WriteLine("Enter an integer.");
                int Integer = Convert.ToInt32(Console.ReadLine());

                

                Console.WriteLine("Number".PadRight(16) + "Squared" + "Cubed".PadLeft(14));
                Console.WriteLine("=======".PadRight(16) + "=======" + "======".PadLeft(14));

                // Processing
                for (int i = 1; i <= Integer; i++)
                {
                    int square = i * i;
                    int cube = i * i * i;
                    Console.WriteLine(i + "\t".PadLeft(10) + square + "\t".PadLeft(14) + cube);

                }

                //Continuation
                Console.WriteLine("Would you like to continue?");
                Response = Console.ReadLine();
                if (Response == "N")
                {
                    break;
                }
            }
           while (Response == "Y");
        }
    }
}
