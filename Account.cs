    abstract class Account
    {
         public int AccountNumber { get; set; }
        public double Balance { get; set; }

        //Constructor:
        public Account(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

    
        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount} into Account {AccountNumber}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than zero.");
            }
        }

        // Method to withdraw money from the account (ensure balance doesn't go negative)
        public virtual void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawn ${amount} from Account {AccountNumber}. New balance: ${Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds to make the withdrawal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Amount must be greater than zero.");
            }
        }    

        public abstract void CalculateAndDisplayDetails();
    }
