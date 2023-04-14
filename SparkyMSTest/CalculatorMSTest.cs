using Sparky;

namespace SparkyMSTest;

[TestClass]
public class CalculatorMSTest
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange --- Initial Set up and used for creating object and create Test Data

                Calculator calc = new Calculator();

        // Act --- Execute Application Code  / Call Methods
                int result =   calc.AddNumbers(10, 20);

       
        // Assert -- Check Results -- Pass / Fail
                Assert.AreEqual(30, result);
        
    }
}


[TestClass]
public class OddNumberChecker {

    [TestMethod]
    public void oddCheckernumber()
    {

        // Arrange

        Calculator calc2 = new();


        // Act

        bool result = calc2.IsOddNumber(20);


        // Assert

        Assert.IsFalse(result);

    }
}
    
