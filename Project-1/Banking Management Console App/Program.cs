namespace Banking_Management_Console_App;

class Program
{
    
    static List<string> customerNames = new List<string>();
    static List<string> accountNumbers = new List<string>();
    static List<double> balances = new List<double>();

    static void Main(string[] args)
    {
        bool exitApp = false;
        while (!exitApp)
        {
            Console.WriteLine("\n===== Welcome to Spark Bank =====");
            Console.WriteLine("1. Add New Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Show Balance");
            Console.WriteLine("5. Transfer Amount");
            Console.WriteLine("6. <your 1st custom service - choose a name>");
            Console.WriteLine("7. <your 2nd custom service - choose a name>");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");


            int choice;
            
          
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    //Service 1 - Add New Account
                    Console.Write("Please enter a name: ");
                    string name = Console.ReadLine();
                    Console.Write("Please enter your account number: ");
                    string AC = (Console.ReadLine());

                    if (accountNumbers.Contains(AC))
                    {
                        Console.Write("Account number already exists. Please choose a different account number");
                        return;
                        
                    }
                    
                    Console.Write("Enter initial deposit: ");
                    double balance = double.Parse(Console.ReadLine());
                    
                    if (balance < 0)
                    {
                        Console.WriteLine("Error: Initial deposit cannot be negative.");
                        return;
                    }
                    
                    customerNames.Add(name);
                    accountNumbers.Add(AC);
                    balances.Add(balance);
                    
                    Console.WriteLine("\nAccount created successfully!");
                    Console.WriteLine("Customer Name: " + name);
                    Console.WriteLine("Account Number: " + AC);
                    Console.WriteLine("Balance: " + balance);
                    break; 
                
                case 2:
                    //Service 2 - Deposit Money
                Console.Write("Please enter your account number: ");
                    string account = Console.ReadLine();
                    int index = accountNumbers.IndexOf(account);
                    
                    if (index < 0)
                    {
                        Console.WriteLine(" Error: Account not found.");
                        return;
                    }
                    Console.Write("Enter initial deposit amount: ");
                    int amount = int.Parse(Console.ReadLine());
                    
                    balances[index] = balances[index] + amount;
                   Console.WriteLine("Updated Balance: " + balances[index]);
                    break;
                
                case 3:
                    //Service 3 - Withdraw Money
                    Console.Write("Please enter your account number: ");
                    string ac = Console.ReadLine();
                    int i = accountNumbers.IndexOf(ac);
                    
                    if (i < 0)
                    {
                        Console.WriteLine(" Error: Account not found.");
                        return;
                    }
                    Console.Write("Enter withdrawal amount: ");
                    int Withdrawal = int.Parse(Console.ReadLine());
                    
                    if (Withdrawal < 0 && Withdrawal > balances.Count )
                    {
                        Console.WriteLine(" Error: Withdrawal is invalid.");
                    }
                    
                    balances[i] = balances[i] - Withdrawal;
                    Console.WriteLine("Updated Balance: " + balances[i]);
                    break;
                    
                case 4:
                    //Service 4 - Show Balance
                
                    Console.Write("Please enter your account number: ");
                    string sb = Console.ReadLine();
                    int ind = accountNumbers.IndexOf(sb);
                    
                    if (ind < 0 )
                    {
                        Console.WriteLine(" Error: Account not found.");
                        return;
                    }
                    
                    Console.WriteLine("\n customer Account details ");
                    Console.WriteLine("Customer Name: " + customerNames[ind]);
                    Console.WriteLine("Account Number: " + accountNumbers[ind]);
                    Console.WriteLine("Balance: " + balances[ind]);
                    break;
                
                case 5:
                    //Service 5 - Transfer Amount
                    Console.Write("Please enter sender account number: ");
                    string senderAC = Console.ReadLine();
                    int senderindex = accountNumbers.IndexOf(senderAC);
                    
                    if (senderindex < 0)
                    {
                        Console.WriteLine(" Error: Account not found.");
                        return;
                    }
                    
                    Console.Write("Please enter receiver account number: ");
                    string receiverAC = Console.ReadLine();
                    int receiverindex = accountNumbers.IndexOf(receiverAC);
                    
                    if (receiverindex < 0)
                    {
                        Console.WriteLine(" Error: Account not found.");
                        return;
                    }

                    Console.WriteLine("enter the amount you want to transfer : ");
                    int transferAmount = int.Parse(Console.ReadLine());

                    if (balances[senderindex] < transferAmount)
                    {
                        Console.WriteLine("Error: the balance is in sufficient.");
                        break;
                    }
                    
                    balances[senderindex] = balances[senderindex] - transferAmount;

                    balances[receiverindex] = balances[receiverindex] + transferAmount;
                    
                    Console.WriteLine("\n sender Account details ");
                    Console.WriteLine("Customer Name: " + customerNames[senderindex]);
                    Console.WriteLine("Account Number: " + accountNumbers[senderindex]);
                    Console.WriteLine("Balance: " + balances[senderindex]); 
                    
                    Console.WriteLine("\n receiver Account details ");
                    Console.WriteLine("Customer Name: " + customerNames[receiverindex]);
                    Console.WriteLine("Account Number: " + accountNumbers[receiverindex]);
                    Console.WriteLine("Balance: " + balances[receiverindex]); 
                    
                    break;
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                

                    
            }

        }

        

        
    }
}