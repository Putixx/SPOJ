using System;

namespace Bank
{
    public class Account : IAccount
    {
        readonly string name;
        public string Name
        {
            get => name;
        }

        private decimal balance;
        public decimal Balance
        {
            get => balance;
        }

        private bool isBlocked;
        public bool IsBlocked
        {
            get => isBlocked;
        }

        public Account(string _name, decimal _balance = 0)
        {
            if (_balance < 0 || _name == null) throw new ArgumentOutOfRangeException();

            _name = _name.Trim();

            if (_name.Length < 3)
            {
                throw new ArgumentException();
            }
            name = _name;
            balance = decimal.Round(_balance, 4);
            Unblock();
        }

        public void Block()
        {
            isBlocked = true;
        }

        public void Unblock()
        {
            isBlocked = false;
        }

        public bool Deposit(decimal amount)
        {
            if (amount >= 0 && !isBlocked)
            {
                balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdrawal(decimal amount)
        {
            if (amount > 0 && amount <= balance && !isBlocked)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (!isBlocked) return $"Account name: {Name}, balance: {(Balance == 0 ? ("0.00") : (decimal.Round(Balance, 2).ToString()))}";
            else return $"Account name: {Name}, balance: {(Balance == 0 ? ("0.00") : (decimal.Round(Balance, 2).ToString()))}, blocked";
        }
    }
}