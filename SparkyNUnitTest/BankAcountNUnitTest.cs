using System;
using Moq;
using Sparky;

namespace SparkyNUnitTest
{

	[TestFixture]
	public class BankAcountNUnitTest
	{
		private BankAccount _bankAccount;

		[SetUp]
		public void SetUp()
		{
			_bankAccount = new BankAccount(new LogBook());
		}

		[Test]
		public void BankDeposit_Add100_ReturnTrue()
		{
			// Act
			var result = _bankAccount.Deposit(100);

			// Assert

			Assert.IsTrue(result);
			Assert.That(_bankAccount.GetBalance, Is.EqualTo(100));
		}

		// Using MOQ implementation
        [Test]
        public void BankDeposit_MOQ_Add100_ReturnTrue()
        {
			var logMock = new Mock<ILogBook>();
			logMock.Setup(x => x.Message("Deposit Method Invoked"));

			// Arrange

			BankAccount account = new(logMock.Object);
            // Act
            var result = _bankAccount.Deposit(100);

            // Assert

            Assert.IsTrue(result);
            Assert.That(_bankAccount.GetBalance, Is.EqualTo(100));
        }

    }
}

