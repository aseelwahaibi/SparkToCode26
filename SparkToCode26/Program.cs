namespace SparkToCode26;

class Program-
{
    static void Main(string[] args)
    {
        //Task 1 - Absolute Difference
        Console.WriteLine("enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        
        int sub = a - b;
        decimal abs = Math.Abs(sub);
        Console.WriteLine("Subtraction resukt is: " + sub);
        Console.WriteLine("Absolute value :  "+abs);
        
    }
}