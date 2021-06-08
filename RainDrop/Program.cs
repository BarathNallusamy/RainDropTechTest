using System;

namespace RainDrop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            int number = ConvertUserInputToNumber(input);
            string value = PlingPlangPlong(number);
            Console.WriteLine(value);
        }

        public static int ConvertUserInputToNumber(string input)
        {
            if (int.TryParse(input,out _))
            {
                int result = int.Parse(input);
                return result;
            }
            else
            {
                throw new FormatException("Invalid user input");
            }
        }

        public static string PlingPlangPlong(int number)
        {
            string result="";
            if(number%3 != 0 && number % 5 != 0 && number % 7 != 0)
            {
                result = number.ToString();
            }
            if(number % 3 == 0)
            {
                result += "Pling";
            }
            if(number % 5 == 0)
            {
                result += "Plang";
            }
            if (number %7==0)
            {
                result += "Plong";
            }
            return result;
        }
    }
}
