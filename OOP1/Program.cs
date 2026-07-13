namespace OOP1;

class Program
{
    //class BankAccount
    public class BankAccount
    {
        //properties 
        public int AccountNumber { get; set; }
        public string HolderName  { get; set; }
        public double Balance { get; set; }
        
        //methods
        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        
        private void PrintInformation()
        {
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
        
        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");
        }
        
        
        //class Student 

        public class Student
        {
            //properties 
            public int Grade  { get; set; }
            public string Name { get; set; }
            public string Address  { get; set; }
            private string email;
            private int age; 
            
            //methods 
            
            public void Register(string email)
            {
                this.email = email;
                SendEmail(); 
            }
            
            
            private void SendEmail()
            {
                Console.WriteLine("Registration Email sent.");
            }
            
            

        }
        
        
        
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}