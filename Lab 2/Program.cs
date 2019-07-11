using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            double length;
            double width;
            double area;
            double perimeter;
            double height;
            double volume;
            char loopBreak;

            //user prompt for input data
            Console.WriteLine("Please enter the length: ");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height: ");
            height = double.Parse(Console.ReadLine());

            //Calculating area
            area = length * width;

            //Calculating perimeter
            perimeter = 2 * (length + width);

            //Calculating volume
            volume = length * width * height;

            //Displaying data to user...
            Console.WriteLine();
            Console.WriteLine($"The area of your rectangle is: {area}");
            Console.WriteLine($"The perimeter of your rectangle is: {perimeter}");
            Console.WriteLine($"The volume of your rectangle is {volume}");

            Console.WriteLine("Do you wish to continue? (enter y or n)");
            loopBreak = char.Parse(Console.ReadLine());

            while (loopBreak == 'y')
            {
                Console.WriteLine("Please enter the length:");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the width");
                width = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the height: ");
                height = double.Parse(Console.ReadLine());


                //Calculating area
                area = length * width;

                //Calculating perimeter
                perimeter = 2 * (length + width);

                //Calculating volume
                volume = length * width * height; 

                //Displaying data to user...
                Console.WriteLine();
                Console.WriteLine($"The area of your rectangle is: {area}");
                Console.WriteLine($"The perimeter of your rectangle is: {perimeter}");
                Console.WriteLine($"The volume of your rectangle is {volume}");


                Console.WriteLine("Do you wish to continue? (enter y or n)");
                loopBreak = char.Parse(Console.ReadLine());
            }

            Console.ReadLine();


        }
    }
}
