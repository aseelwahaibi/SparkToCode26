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
        


    }
}