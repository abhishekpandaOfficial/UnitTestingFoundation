using System;
using Sparky;
namespace SparkyNUnitTest
{
	[TestFixture]
	public class CustomerNUnitTests
	{
		private Customer _customer;

		[SetUp]
		public void SetUp()
		{

			_customer = new Customer();

        }


		[Test]
		public void Greetings()
		{
			// Arrange

			//Customer cs = new Customer();

			// Act

			string fullName = _customer.GreetAndCombine_Name("Abhishek", "Panda");

			// Assert

			Assert.That(fullName, Is.EqualTo(" Hello Abhishek Panda"));

			//Assert.AreEqual(fullName, " Hello Abhishek Panda");
			Assert.That(fullName, Does.Contain(" "));
			Assert.That(fullName, Does.StartWith(" Hello"));
			Assert.That(fullName, Does.EndWith("Panda"));
			Assert.That(fullName, Does.Match(" Hello [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }


		[Test]
		public void Greet_ReturnNull()
		{
			// Arrange

			//Customer cs = new Customer();

			// Act
			 //cs.GreetAndCombine_Name(" John", "Smith");
            // Assert

            Assert.IsNull(_customer.GreetMessage);
		}
	}
}

