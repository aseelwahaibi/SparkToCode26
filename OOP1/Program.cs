using System.Reflection.Metadata.Ecma335;

namespace OOP1;

class Program
{
    //class BankAccount
    public class BankAccount
    {
        //properties 
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
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

        public double CheckBalance()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
            return Balance;
        }
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
        }

        //class program 
            public class Program
            {
                static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "karim", Balance = 120 };
                static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };
                
                static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
                static Student student2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };
                
                static Product product1 = new Product {ProductName = "Wireless Mouse", Price= 5.500 , StockQuantity = 50 };
                static Product product2 = new Product {ProductName = "Mechanical Keyboard", Price= 15.750 , StockQuantity = 20 };


                static void Main(string[] args)
                {
                bool exitApp = false;

                 while (exitApp == false) 
                 { 
                    Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager ====="); 
                    Console.WriteLine(" 1. View Account Details");
                    Console.WriteLine(" 2. Update Student Address"); 
                    Console.WriteLine(" 3. Make a Deposit");
                    Console.WriteLine(" 4. Make a Withdrawal");
                    Console.WriteLine(" 5. View Product Details");
                    Console.WriteLine(" 6. Register a Student"); 
                    Console.WriteLine(" 7. Compare Two Account Balances");
                    Console.WriteLine(" 8. Restock Product & Stock Level Check");
                    Console.WriteLine("9. Exit");
                    Console.Write("Choose an option: ");

                    int choice; 
                    
                    try
                  {
                    choice = int.Parse(Console.ReadLine());
                  }
                    
                    
                    catch (Exception) 
                    {
                         Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                         continue;
                    }

                    
                     switch (choice)
                     {
                        case 1: ViewAccountDetails(); break;
                        case 2: UpdateStudentAddress(); break;
                        case 3: MakeDeposit(); break;
                        case 4: MakeWithdrawal(); break;
                        case 5: ViewProductDetails(); break;
                        case 6: RegisterStudent(); break;
                        case 7: CompareAccountBalances(); break;
                        case 8: RestockProduct(); break;
                        case 9:
                            exitApp = true;
                                Console.WriteLine("Goodbye!");
                                break;
                            default:
                                Console.WriteLine("Invalid option, please choose between 1 and 20.");
                                break;
                                
                                
                          //case 1       
                        static void ViewAccountDetails()
                        {
                            Console.WriteLine("\n--- View Account Details ---");
                            Console.WriteLine("Which account would you like to view?");
                            Console.WriteLine("1. Account 1 (" + account1.HolderName + ")");
                            Console.WriteLine("2. Account 2 (" + account2.HolderName + ")");
                            Console.Write("Choose an option (1 or 2): ");

                            int accountChoice;
                            try
                            {
                                accountChoice = int.Parse(Console.ReadLine());
                            }
                            
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid input. Returning to main menu.");
                                return;
                            }

                            if (accountChoice == 1)
                            {
                                Console.WriteLine("\n--- Showing Account 1 Details ---");
                                account1.CheckBalance();
                            }
                            
                            else if (accountChoice == 2)
                            {
                                Console.WriteLine("\n--- Showing Account 2 Details ---");
                                account2.CheckBalance();
                            }
                            
                            else
                            {
                                Console.WriteLine("Invalid choice. Please select 1 or 2.");
                            }
                }
                
                

    }
}