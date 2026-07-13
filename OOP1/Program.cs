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
        
        // class Product

        class Product
        {
            public string ProductName;
            public double Price;
            public int StockQuantity;

            public void Sell(int quantity)
            {
                if (StockQuantity >= quantity)
                {
                    StockQuantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock.");
                }

                LogTransaction();
            }

            public void Restock(int quantity)
            {
                StockQuantity += quantity;
                LogTransaction();
            }

            public double GetInventoryValue()
            {
                PrintDetails();
                return Price * StockQuantity;
            }

            private void PrintDetails()
            {
                Console.WriteLine("Product Name: " + ProductName);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("Stock Quantity: " + StockQuantity);
            }

            private void LogTransaction()
            {
                Console.WriteLine("Transaction logged.");
            }

            //class program 
            public class Program
            {
                static BankAccount account1 = new BankAccount
                {
                    AccountNumber = 1163,
                    HolderName = "karim",
                    Balance = 120
                };

                static BankAccount account2 = new BankAccount
                {
                    AccountNumber = 15203,
                    HolderName = "Ali",
                    Balance = 63
                };
                
                
                // Students
                static Student student1 = new Student
                {
                    Name = "Ali",
                    Address = "Muscat",
                    Grade = 65
                };

                static Student student2 = new Student
                {
                    Name = "Ahmed",
                    Address = "Muscat",
                    Grade = 70
                };
                
                // Products
                static Product product1 = new Product
                {
                    ProductName = "Wireless Mouse",
                    Price = 5.500,
                    StockQuantity = 50
                };

                static Product product2 = new Product
                {
                    ProductName = "Mechanical Keyboard",
                    Price = 15.750,
                    StockQuantity = 20
                };

                
                
            }
            
            
            
            
            
        }
        
        
        
    }
    static void Main(string[] args)
    {
        //Accounts 
        BankAccount account1 = new BankAccount();
        BankAccount account2 = new BankAccount();

        account1.AccountNumber = 1163;
        account1.HolderName = "Karim";
        account1.Balance = 120;

        account2.AccountNumber = 15203;
        account2.HolderName = "Ali";
        account2.Balance = 63;
        
        

    }
}