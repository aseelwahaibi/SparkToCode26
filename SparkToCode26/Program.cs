namespace SparkToCode26;

class Program
{
    static void Main(string[] args)
    {
        //Task 1 - Absolute Difference
        /*
        Console.WriteLine("enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        
        int sub = a - b;
        decimal abs = Math.Abs(sub);
        Console.WriteLine("Subtraction resukt is: " + sub);
        Console.WriteLine("Absolute value :  "+abs);
        */
        
        //Task 2 - Power & Root Explorer
        /*
        Console.WriteLine("enter a number:  ");
        int a = int.Parse(Console.ReadLine());
        
        double p = Math.Pow(a, 2);
        double s = Math.Sqrt (a);
        
        Console.WriteLine ("The power of " + a + " is " + p);
        Console.WriteLine ("the square root of  " +a+ " is " +  s);
        */
        
        
        // Task 3 - Name Formatter 
        
        /* Console.WriteLine("enter your name:  ");
        string name = Console.ReadLine();
        
        string upper =  name.ToUpper();
        string lower = name.ToLower();
        int length = name.Length;
        
        Console.WriteLine("your name  in upper case : " + upper);
        Console.WriteLine("your name  in lower case: " + lower);
        Console.WriteLine("the length of your name is : " + length);
        */
        
        
        //Task 4 - Subscription End Date
        /*
        Console.WriteLine("enter the number of a free trail : ");
        int n = int.Parse(Console.ReadLine());
        
        DateTime today = DateTime.Today;
        Console.WriteLine("today is : " + today);
        
        DateTime end = today.AddDays(n);
        
        string trailend = end.ToString("yyyy-MM-dd");
        Console.WriteLine("the end of the trail  is  in :  "+trailend);
        */
        
        //Task 5 - Grade Rounding System
        Console.WriteLine("enter exam score in decimal:  ");
        decimal examScore = decimal.Parse(Console.ReadLine());
        
        decimal round = Math.Round(examScore, 0);
        Console.WriteLine("the result is :  " + round);

        if (round >= 60)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
       
    }
}