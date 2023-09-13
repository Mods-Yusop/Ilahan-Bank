class CheckingAccount : Account
    {
        public double OverdraftLimit { get; set; }

        public CheckingAccount(int accountNumber, double balance, double overdraftLimit) : base(accountNumber, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            // Withdraw method with overdraft limit as before...
        }

        public override void CalculateAndDisplayDetails()
        {
            Console.WriteLine($"Account Type: Checking Account");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: ${Balance}");
            Console.WriteLine($"Overdraft Limit: ${OverdraftLimit}");
            Console.WriteLine();
        }
    }