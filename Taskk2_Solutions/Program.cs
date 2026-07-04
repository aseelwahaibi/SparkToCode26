using System.Linq.Expressions;

namespace Taskk2_Solutions;

class Program
{
    static void Main(string[] args)
    {
        //Task 1 - Countdown Timer
        /*
        Console.WriteLine("enter a starting number");

        int CD = int.Parse(Console.ReadLine());

        for ( int i =CD; CD  > 0; CD --)
        {
            Console.WriteLine(CD);
        }
        Console.WriteLine("Liftoff!");
        */

        //Task 2 - Sum of Numbers 1 to N
        /*
        Console.Write(" enter a positive whole number:  ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        
        for (int i = 1; i <= n; i++)
        { 
            sum += i ;
        }
        
        Console.WriteLine("the total sum : " + sum);
*/
        
        
        //Task 3 - Multiplication Table
        /*
        Console.Write(" enter number:  ");
        int n = int.Parse(Console.ReadLine());
        
        for(int M=1 ; M<=10 ; M++)
        {
            Console.WriteLine(M + " X " +n +" = " + M*n  );
        }
        */
        
        //Task 4 - Password Retry
/*
        string password = "Spark2026";
        string userinput=""; 
        
        
        while (userinput != password)
        {
            Console.Write("enter password:  ");
            userinput = Console.ReadLine();
        }

        if (userinput != password)
        {
            Console.Write("Incorrect password, try again");
        }
        
        Console.WriteLine("Access Granted");
        */

// Task 5 - Number Guessing Game
/*
        int SecretNumber = 42;
        int Gnumber; 
        int attempts = 0;

        do
        {
            Console.Write("Guess the number: ");
            Gnumber = int.Parse(Console.ReadLine());
            attempts++;

            if (SecretNumber < Gnumber)
            {
                Console.WriteLine("too high");
            }
            else if (SecretNumber > Gnumber)
            {
                Console.WriteLine("too low");
            }
            else
            {
                Console.WriteLine("Correct!");
            }

        }
        while (Gnumber != SecretNumber);

        Console.WriteLine("Number of ayyempts:  " + attempts);

*/

// Task 6 - Safe Division Calculator
/*
        try
        {
            Console.Write("first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int D = firstNumber / secondNumber;
            Console.Write("result = " + D);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("you can't divide by zero");

        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input");
        }
        
        */


        // task 7 Repeating Menu with Exit Option

        int option = 0;
        bool running = true;

        while (running==true)
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) say hello!");
            Console.WriteLine("2) show greetings!");
            Console.WriteLine("3) exit");
            Console.Write("Enter your choice: ");

            try
            {
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;

                    case 2:
                        Console.WriteLine("Good morning!");
                        break;

                    case 3:
                        Console.WriteLine("Exiting program...");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, reenter a number from 1 to 3.");
                        break;
                }



            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            
            
        }














    }

}    