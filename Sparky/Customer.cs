using System;
namespace Sparky
{
	public class Customer
	{
		public Customer()
		{
		}

		//public string FirstName { get; set; }
		//public string LastName { get; set; }

		public string GreetMessage { get; set; }

		public string GreetAndCombine_Name(string firstName, string lastName)
		{
			string GreetMessage = " Hello" + " " + firstName + " " +lastName;
			return GreetMessage;
		}
	}
}

