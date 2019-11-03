using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0.0, radius=0.0;
            string answer="", valid="y";
            var userInput="";
            string  numbers = "1234567890";
            do
            {
                do
                {
                    radius = 0.0;
                    answer = "";
                    valid = "y";
                    userInput = "";

                    Console.WriteLine("Enter the radius of the circle : ");
                    userInput = Console.ReadLine();
                    //if (!IsAllDigits(userInput))
                    if (!numbers.Contains(userInput ))
                    {
                        Console.WriteLine("Error: The radius must to be number");
                        Console.ReadLine();
                        valid = "n";
                    }
                    else
                    {
                        radius = Convert.ToDouble(userInput);
                        if (radius <= 0)
                        {
                            Console.WriteLine("Error: The radius must to be a positive value biggest than 0");
                            Console.ReadLine();
                            valid = "n";
                        }
                    }
                    


                } while (valid=="n");

                area = radius * radius * 3.1416;
                Console.WriteLine("The circle's area is = {0}", area);
                Console.ReadLine();
                Console.WriteLine("Do you want calculate another area ? (Y) : ");
                answer = Console.ReadLine();

            } while (answer == "y" || answer == "Y");
            
        }

        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    } 
}
