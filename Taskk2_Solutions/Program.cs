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
        Console.Write(" enter number:  ");
        int N = int.Parse(Console.ReadLine());
        
        for (int M= 1; M <= 10; M++)
        {
            Console.WriteLine(N + " x " + M + " = " + (N * M));
        }
        
        
        
    }

}    