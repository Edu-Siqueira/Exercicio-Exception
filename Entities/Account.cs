using ExercicioException.Entities.Exceptions;

namespace ExercicioException.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value > Balance)
            {
                throw new WithdrawException("Not enough balance.");
            }

            if (value > WithdrawLimit)
            {
                throw new WithdrawException("The amount exceeds withdraw limit.");
            }

            Balance -= value;
        }
    }
}