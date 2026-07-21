namespace Task5_solutions;

class Program
{
    static void Main(string[] args)
    {
     //Task 1 - Fixed Grades Array
     /*
     int[] grades = new int[4]; 
      grades[0] = 90;
      grades[1] = 85;
      grades[2] = 70;
      grades[3] = 60;

      int counter = 0;
      for (counter = 0; counter < 4; counter++) //Input and store the grades.
      {
          Console.Write("Enter grade " + (counter + 1) + ": ");
          grades[counter] = int.Parse(Console.ReadLine());
          
          foreach (int grade in grades) //Read and print the grades.
          {
              Console.WriteLine(grade);
          }
      }
*/
     
     
     
     ///////////////////////////////////////
     
     //Task 2 - Dynamic To-Do List
     /*
     List<string> todo = new List<string>();
     todo.Add("finish today tasks");
     todo.Add("watch recorded session");
     todo.Add("practice tasks");

     int counter = 0; 
     
     for (counter = 0; counter < 4; counter++) 
     {
         Console.Write("enter 5 tasks  " + (counter + 1) + ": ");
         string task = Console.ReadLine();
         todo.Add(task); 
         
         
     }
     foreach (string task in todo) 
     {
         Console.WriteLine("- "+task);
     }
     */
     
     ////////////////////////////
     // Task 3 - Browsing History Stack
     /*
     Stack<string> browsing =  new Stack<string>();
     int counter = 0;

     for (counter = 0; counter < 3; counter++)
     {
         Console.WriteLine("enter a website URL: " + (counter + 1));
         string websiteURL = Console.ReadLine();
         browsing.Push(websiteURL);
     }
     
     string browsingURL = browsing.Pop();
     Console.WriteLine("You went back from:  "+browsingURL);
     */
     
     ///////////////////////////////////////////////////
     //Task 4 - Customer Service Queue
     /*
     Queue<string> customers = new Queue<string>();
     int counter = 0;

     for (counter = 0; counter < 3; counter++)
     {
         Console.WriteLine("enter customer name : " + (counter + 1));
         string name = Console.ReadLine();
         customers.Enqueue(name);
         
     }
     
     string servedCustomer = customers.Dequeue();
     Console.WriteLine("Customer served: " + servedCustomer);
     
     */
     /////////////////////////////////////////////////////////
     
     //Task 5 - Array Grade Range

     int[] grades = new int[5];
    
     int counter = 0;
     for (counter = 0; counter <grades.Length; counter++)
     {
         Console.WriteLine("enter grade : " + (counter + 1));
         grades[counter] = int.Parse(Console.ReadLine());
         
     }
     
     
     Array.Sort(grades);

     int sum = 0;

     for (int counter = 0; counter < grades.Length; counter++)
     {
         sum += grades[counter];
     }
     
     int max = Math.Max( grades[5]);
     int min = Math.Min(counter, grades[0]);
     int avg = (max + min) / 2;
     
     
     Console.WriteLine("maximum grade is: " + max);
     Console.WriteLine("minimum grade is: " + min);
     Console.WriteLine("avg grade is: " + avg);










    }
}