namespace ConsoleBankProject.Entities
{
    public class Account : User
    {
        public string AccountName { get; set; }
       
        public double AccountNumber { get; set; }
         
        private double _currentAccount;
        public double CurrentAccount
        {
            get { return _currentAccount; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("You are not allowed to have less than N0.00");
                _currentAccount = value;
            }
        }

        private double _savingsAccount;
        public double SavingsAccount
        {
            get { return _savingsAccount; }
            set
            {
                if (value < 1000)
                    throw new ArgumentOutOfRangeException("You are not allowed to have less than N1000.00");
                _savingsAccount = value;
            }
        }

        public List<Transactions> TransactionTypes { get; set; }
    }
}
