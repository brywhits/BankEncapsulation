namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0;
    
    public double GetBalance()
    {
        return _balance;
    }
    // Define a method named Deposit that will accept a double and store that value in the balance field
    public void Deposit(double amount)
    {
        _balance += amount;
    }
    public void Withdraw(double amount)
    {
        _balance -= amount;
    }
}