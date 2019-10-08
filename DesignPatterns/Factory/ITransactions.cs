namespace DesignPatterns.Factory
{
    public interface ITransactions
    {
        double Deposit(string account,double amount);
        double WithDraw(string account,double amount);
        double CheckBalance(string account);
    }
}
