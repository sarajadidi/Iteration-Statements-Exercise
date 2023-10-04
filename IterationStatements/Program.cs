namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        // 1 - Write a method that will print to the console all numbers 1000 through - 1000

        // 2 - Write a method that will print to the console numbers 3 through 999 by 3 each time

        // 3 - Write a method to accept two integers as parameterss and check whether they are equal or not
        
        // 4 - Write a method to check whether a given number is even or odd
        
        // 5 - Write a method to check whether a given number is positive or negative
        
        // 6 - Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:// 7
        //Write a method to check if an integer(from the user) is in the range -10 to 10 

        // 8
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            OutputFrom1000();//1

            Console.WriteLine("press enter");
            Console.ReadKey();

            JumpByThree();//2

            Console.WriteLine("press enter");
            Console.ReadKey();

            int num1 = 5;
            int num2 = 10;
            int number = 17;

            if (AreTheyEqual(num1, num2)) //3
            {
                Console.WriteLine("They are equal!");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }

            Console.WriteLine("press enter");
            Console.ReadKey();

            
            Console.WriteLine(EvenOrOdd(number)); //4

            Console.WriteLine("press enter");
            Console.ReadKey();

            if (PosOrNeg(number)) //5
            {
                Console.WriteLine("Positive!");
            }
            else if(number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else
            {
                Console.WriteLine("negative!");
            }

            Console.WriteLine("press enter");
            Console.ReadKey();

            Console.WriteLine("Enter your age"); //6
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (CheckMyAge(age))
                {
                    Console.WriteLine("Congrats, You can vote!");
                }
                else
                {
                    Console.WriteLine("You cannot vote.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
            }

            Console.WriteLine("Please enter a number"); //7
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                if (InRange(userInput, -10, 10))
                {
                    Console.WriteLine("You are in range!");
                }
                else
                {
                    Console.WriteLine("The integer you entered is outside the range.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            Console.WriteLine("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int givenNumber))
            {
                OutputMultiplication(givenNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        // 1
        static void OutputFrom1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2
        static void JumpByThree()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        // 3
        static bool AreTheyEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 4
        public static string EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                return ("Even");
            }
            else
            {
                return ("Odd");
            }
        }

        //5
        static bool PosOrNeg(int number)
        {
            return number > 0;
        }
        //6
         static bool CheckMyAge(int age)
        {
            return age >= 18;
        }
        //7
        static bool InRange(int userInput, int minValue, int maxValue)
        {
            return userInput >= minValue && userInput <= maxValue;
        }
        //8
        static void OutputMultiplication(int givenNumber)
        {
            Console.WriteLine($"Multiplication Table for {givenNumber}:");

            for (int a = 1; a <= 12; a++)
            {
                int result = givenNumber * a;
                Console.WriteLine($"{givenNumber} x {a} = {result}");
            }
        }
    }
}
