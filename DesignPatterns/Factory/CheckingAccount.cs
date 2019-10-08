namespace DesignPatterns.Factory
{
    public class CheckingAccount: ITransactions
    {
        private double _amount;

        public CheckingAccount()
        {
            _amount = 500.00;
        }
        public double Deposit(string account,double amount)
        {
            _amount = _amount + amount;
            return CheckBalance(account);
        }

        public double WithDraw(string account,double amount)
        {
            _amount = _amount - amount;
            return CheckBalance(account);
        }

        public double CheckBalance(string account)
        {
            return _amount;
        }
    }
}
