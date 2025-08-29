namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var account1 = new BankAccount();
            
            Console.WriteLine("Welcome to the Banking Application!.");
            Console.WriteLine("*****************************************");

            while (true)
            {
                Console.WriteLine("\nPlease select an option: ");
                Console.WriteLine("1) Get Balance");
                Console.WriteLine("2) Deposit Money");
                Console.WriteLine("3) Withdraw Money");
                Console.WriteLine("4) Exit");
                Console.Write("Press 1-4: ");

                string choice = Console.ReadLine();
                Console.WriteLine(choice); // echo the choice so the user sees it

                switch (choice)
                {
                    case "1": 
                        Console.WriteLine($"Current balance: ${account1.GetBalance()}.");
                        break;
                    
                    case "2":
                        Console.WriteLine("Please enter the amount you would like to deposit: ");
                        if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
                        {
                            Console.WriteLine("Invalid amount.Please enter a positive number.");
                            continue;
                        }
                        account1.Deposit(amount);
                        Console.WriteLine($"\n--- Transaction Receipt ---");
                        Console.WriteLine($"Deposit Amount: {amount:C2}");
                        Console.WriteLine($"New Balance: {account1.GetBalance():C2}");
                        Console.WriteLine("----------------------------");
                        break;
                    
                    case "3":
                        Console.WriteLine("Enter amount to withdraw: ");
                        if (!double.TryParse(Console.ReadLine(), out double amount2) || amount2 < 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }

                        if (amount2 > account1.GetBalance())
                        {
                            Console.WriteLine("Insufficient funds. ");
                            Console.WriteLine($"Your current balance is {account1.GetBalance():C2}.");
                        }
                        else
                        {
                            account1.Withdraw(amount2); // subtracting like a withdrawal
                            Console.WriteLine($"Please take your cash: {amount2:C2}");
                            Console.WriteLine($"Your new balance is {account1.GetBalance():C2}.");
                        }
                        break;
                    
                    case "4":
                        Console.WriteLine("Thank you for using the Banking Application!.");
                        return;
                    
                    default:
                        Console.WriteLine("Invalid option. Please enter 1, 2, 3 or 4.");
                        break;
                }
            }

        }
    }
}
