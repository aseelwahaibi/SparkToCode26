namespace Task5_solutions;

class Program
{
    static void Main(string[] args)
    {
     //Task 1 - Fixed Grades Array
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

    }
}