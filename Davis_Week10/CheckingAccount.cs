/// <summary>
/// The CheckingAccount that inherits the Account Class
/// </summary>
public class CheckingAccount : Account
{
    /// <summary>
    /// The private instance fee variable.
    /// </summary>
    private decimal fee;
    /// <summary>
    /// CheckingAccount object class constructor that takes an inital balance and initial fee.
    /// </summary>
    /// <param name="initBalance">Initial Account balance.</param>
    /// <param name="initFee">Initial Account fee.</param>
    public CheckingAccount(decimal initBalance, decimal initFee) : base(initBalance)
    {
        fee = initFee;
    }
    /// <summary>
    /// Credits the Checking account and charges it a fee for the transaction.
    /// </summary>
    /// <param name="amount">The amount to credit the account.</param>
    public override void Credit(decimal amount)
    {
        base.Credit(amount);
        base.Debit(fee);
    }
    /// <summary>
    /// Debits the Checking account, charges a fee if the debit transaction was succesful and returns true/false if succesful.
    /// </summary>
    /// <param name="amount">The amount to debit the account.</param>
    /// <returns>True or false if transaction was successful.</returns>
    public override bool Debit(decimal amount)
    {
        bool success = base.Debit(amount);
        if (success)
        {
            base.Debit(fee);
        }
        return success;
    }
}
