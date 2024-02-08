using System;
/// <summary>
///  Base Account class
/// </summary>
public class Account
{
    /// <summary>
    /// private Account Balance instance variable
    /// </summary>
    private decimal balance;

    /// <summary>
    /// Account class constructor that takes an initial balance.
    /// </summary>
    /// <param name="initBalance">The initial balance of the Account object class.</param>
    /// <exception cref="ArgumentException">Throws an Exception if the initial balance is negative.</exception>
    public Account(decimal initBalance)
    {
        if(initBalance < 0.0m)
        {
            throw new ArgumentException("Initial balance can not be negative");
        }
        balance = initBalance;
    }
    /// <summary>
    /// Returns the Account balance variable
    /// </summary>
    public decimal Balance
    {
        get { return balance; }
    }
    /// <summary>
    /// Credits the Account balance.
    /// </summary>
    /// <param name="amount">The amount to add to the account balance.</param>
    public virtual void Credit(decimal amount)
    {
        balance += amount;
    }
    /// <summary>
    /// Debits the Account balance.
    /// </summary>
    /// <param name="amount">The amount to subtract from the account balance.</param>
    /// <returns>Whether the debit transaction was successful or not.</returns>
    public virtual bool Debit(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Debit amount exceeded the account balance.");
            return false;
        }
        balance -= amount;
        return true;
    }
}
