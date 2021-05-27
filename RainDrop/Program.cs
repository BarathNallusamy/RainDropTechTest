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
                string value = PlingPlangPlong(number);
                Console.WriteLine(value);
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
            string result="";
            if(number%3 != 0 && number % 5 != 0 && number % 7 != 0)
            {
                return result = number.ToString();
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
