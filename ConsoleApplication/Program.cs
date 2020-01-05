using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // personal info
            string name = "Alex Shnyrov";
            string location = "Rexburg, ID";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"My location is {location}\n");

            // working with dates
            DateTime today = DateTime.Now;
            DateTime christmas = new DateTime(2020, 12, 25);
            int daysTilChristmas = (int)Math.Round((christmas - today).TotalDays);

            Console.WriteLine($"Today is {today.ToString("d")}");
            Console.WriteLine($"Christmas is coming in {daysTilChristmas} days");

            // program example from chapter 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            // pause console
            Console.ReadKey();
        }
    }
}
