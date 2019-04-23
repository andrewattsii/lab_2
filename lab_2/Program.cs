using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, area, perimeter;
            string response;


            do
            {
                Console.WriteLine("WELCOME TO THE GRAND CIRCUS' ROOM DETAIL GENERATOR");
                Console.Write("Enter leghnth :");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter width :");
                width = double.Parse(Console.ReadLine());

                area = length * width;
                perimeter = 2 * length  + 2 * width ;

                Console.WriteLine("Your area is : {0} ", area);
                Console.WriteLine("Your perimiter is {0}", perimeter);
                Console.WriteLine("Would you like to continue  y/n ");
                response = Console.ReadLine();
            }
            while (response == "y");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Goodbye !");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
