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





    }
}