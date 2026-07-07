namespace Task4_Solutions;

class Program
{
    //task1 - Personalized Welcome Function
    public static void PrintWelcome(string name)
    {
        Console.WriteLine("Welcome "+name);
    }
    
    
    
    //Task 2 - Square Number Function
    public int Square(int number)
    {
        return number * number;
    }
    
    
    
    //Task 3 - Celsius to Fahrenheit Function
    static double  CelsiusToFahrenheit(double number)
    {
        return (number * 9 / 5) + 32; 
    }
    
    
    
    //Task 4 - Fixed Menu Display Function

    public  static void PrintMenu()
    {
        Console.WriteLine ("Welcome to Task 4");
        Console.WriteLine ("Main Menu");
        Console.WriteLine ("1. Start");
        Console.WriteLine ("2. Help");
        Console.WriteLine ("3. Exit");
        
    }
    
    
    //Task 5 - Even or Odd Function

    public static bool  IsEven(int number)
    {
        return number % 2 == 0;

    }
    
    //Task 6 - Rectangle Area & Perimeter Functions
    //Area 
    public static double CalculateArea(double L, double W)
    {
        return L * W;
    }

    public static double CalculatePerimeter(double L, double W)
    {
        return 2* (L + W);
    }    
    
    //Task 7 - Grade Letter Function 
    public static string GetGradeLetter(int grade)
    {
        if (grade >= 80)
        {
            return "A";
        }
        else if (grade >= 70)
        {
            return "B";
        }
        else if (grade >= 65)
        {
            return "C";
        }
        else if (grade >= 50)
        {
            return "D";
        }
        else 
        {
            return "F";
            
        }
    }

//Task 8 - Countdown Function

    public static void   Countdown(int number)
    {
        int counter = number;
        for (counter = number; counter >= 1; counter--)
        {
            Console.WriteLine(counter);
        }
    }








    static void Main(string[] args)
    {
        //PrintWelcome("Aseel"); task 1

        /*
         -task 2
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int square = Square(number);
        Console.WriteLine(square);

        */


        /*
         task 3
        Console.Write("Enter a degree in Celsius: ");
        int number = int.Parse(Console.ReadLine());
        double CtF = CelsiusToFahrenheit(number);
        Console.WriteLine("the degree in Fahrenheit is :  " + CtF);
        */


        //Task 4 
        // PrintMenu();

        //task 5 
        /*
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool even = IsEven(number);

        if (even)
        {
            Console.WriteLine("true its a even number");

        }
        else
        {
            Console.WriteLine("false its an odd number");
        }
 */

//task 6 
/*
        Console.Write("Enter the length of Rectangle:  ");
        double L = double.Parse(Console.ReadLine());

        Console.Write("Enter the Width of Rectangle: ");
        double W = double.Parse(Console.ReadLine());

      Console.WriteLine("The area of Rectangle:" + CalculateArea(L,W));
      Console.WriteLine("The area of Perimeter:" + CalculatePerimeter(L,W));
    }
    */
        //task 7
        /*
        Console.WriteLine(" enter your grade in number ");
        int grade = int.Parse(Console.ReadLine());
        
        Console.WriteLine(" your grade in letter is :  " + GetGradeLetter(grade));
*/
        
        

     //task 8 
     Console.Write("enter a number to countdown: ");
     int number = int.Parse(Console.ReadLine());
     Countdown(number);






    }
}