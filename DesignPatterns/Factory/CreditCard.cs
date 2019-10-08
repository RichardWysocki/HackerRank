namespace DesignPatterns.Factory
{
    public class CreditCard: ITransactions
    {
        private double _amount;

        public CreditCard()
        {
            _amount = 400.00;

        }
        public double Deposit(string account, double amount)
        {
            _amount = _amount + amount;
            return CheckBalance(account);
        }

        public double WithDraw(string account, double amount)
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
