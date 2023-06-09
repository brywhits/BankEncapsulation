namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var michaelsAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            michaelsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {michaelsAccount.GetBalance}");


        }
    }
}
