class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount(1, 1000.0, 5.0);
            CheckingAccount checkingAccount = new CheckingAccount(2, 500.0, 200.0);

            savingsAccount.Deposit(500.0);
            savingsAccount.Withdraw(200.0);
            savingsAccount.CalculateInterest();

            checkingAccount.Deposit(300.0);
            checkingAccount.Withdraw(800.0);

            // Use polymorphism to call the common method
            DisplayAccountDetails(savingsAccount);
            DisplayAccountDetails(checkingAccount);
        }

        static void DisplayAccountDetails(Account account)
        {
            account.CalculateAndDisplayDetails();
        }
    }
