class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, double balance, double interestRate) : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest()
        {
            // Calculate interest and add it to the balance
            double interest = Balance * (InterestRate / 100);
            Balance += interest;
        }

        public override void CalculateAndDisplayDetails()
        {
            Console.WriteLine($"Account Type: Savings Account");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: ${Balance}");
            Console.WriteLine($"Interest Rate: {InterestRate}%");
            Console.WriteLine();
        }
    }