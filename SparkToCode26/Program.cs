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
        /*
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
       */
        
        
        //Task 6 - Password Strength Checker
        /*
        Console.WriteLine("enter your password : ");
        string password = Console.ReadLine();
        
        int length = password.Length;
        bool contain = password.Contains("password");

        if (contain == true && length <= 8)
        {
            Console.WriteLine("weak:  your password should not contain a word password and shorter than 8 characters");
        }
        else  if (contain == false && length >= 8)
        {
            Console.WriteLine("strong:  your password is long ");
        }
        else if (contain == true && length >= 8)
        {
            Console.WriteLine("weak:  remove the word password ");
        }
        else if (contain == false && length <= 8)
        {
            Console.WriteLine("weak:  your password is shorter than 8 characters ");
        }
        */
        
        
        
       //Task 7 - Clean Name Comparator
       /*
       Console.Write("Enter the first name: ");
       string name1 = Console.ReadLine();
       
       Console.Write("Enter the second name again: ");
       string name2 = Console.ReadLine();
       
       string cleanName1 = name1.Trim().ToUpper();
       string cleanName2 = name2.Trim().ToUpper();
       
       if (cleanName1 == cleanName2)
       {
           Console.WriteLine("Match");
       }
       else
       {
           Console.WriteLine("No Match");
       }
       */
       
       
       //Task 8 - Membership Expiry Checker
       
       Console.Write("Enter membership start date (YYYY-MM-DD): ");
       string start = Console.ReadLine();
       DateTime startDate = DateTime.Parse(start);
       
       Console.WriteLine("enter the number of valid days : ");
       int VD = int.Parse(Console.ReadLine());
       
       DateTime EDate = startDate.AddDays(VD);

       if (EDate <= DateTime.Now)
       {
           Console.WriteLine("Your membership is expired ");
       }

       else if (EDate > DateTime.Now)
       {
           Console.WriteLine("Your membership is active  ");
       }
       
           
       
       
       
       
        
        
    }
}