using System;
namespace Sparky
{
	public class BankAccount
	{

		public int _balance { get; set; }
		private readonly ILogBook _logBook;

		public BankAccount(ILogBook logBook)
		{
			_balance = 0;
			_logBook = logBook;
		}

       

        public bool Deposit(int amount)
		{
			_logBook.Message("Deposit Method Invoked");
			_balance += amount;
			return true;
		}

        public bool Withdraw(int amount)
        {
			if(amount <= _balance)
			{
                _balance -= amount;
                return true;
            }
			else
			{
				return false;
			}
            
        }


		public int GetBalance()
		{
			return _balance;
		}
    }
}

