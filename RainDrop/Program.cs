using System;

namespace RainDrop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int number=0;

            if(int.TryParse(input,out number))
            {
                number = int.Parse(input);
                PlingPlangPlong(number);
            }
            else
            {
                do
                {
                    Console.Write("Invalid input please try again: ");
                    input = Console.ReadLine();
                } 
                while (int.TryParse(input, out number));
                number = int.Parse(input);
                PlingPlangPlong(number);

            }
        }

        public static string PlingPlangPlong(int number)
        {
            return "";
        }
    }
}
