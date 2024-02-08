/// <summary>
/// SavingsAccount class object that inherits the Account class.
/// </summary>
public class SavingsAccount : Account
{
    /// <summary>
    /// Private instance interestRate variable.
    /// </summary>
    private decimal interestRate;
    /// <summary>
    /// SavingsAccount object class constructor that takes an initial balance and inital interest rate.
    /// </summary>
    /// <param name="initBalance">Initial account balance</param>
    /// <param name="initInterestRate">Initial account interest rate.</param>
    public SavingsAccount(decimal initBalance, decimal initInterestRate) : base(initBalance)
    {
        interestRate = initInterestRate;
    }
    /// <summary>
    /// Calculates the interest rate amount of the account based off the balance.
    /// </summary>
    /// <returns>The Account's interest rate amount.</returns>
    public decimal CalculateInterest()
    {
        return Balance * interestRate;
    }
}
