using Sparky;

namespace SparkyNUnitTest;

[TestFixture]
public class CalculatorNUnitTest
{
    private Calculator _calc;

    [SetUp]
    public void SetUp()
    {
        _calc = new Calculator();
    }


    [Test]
    public void AddNumbers_NUnitTest()
    {
        // Arrange -- Create Instance

        //Calculator calc = new();

        // Act -- Calling the Methods

      int result = _calc.AddNumbers(20, 30);

        // Assert -- Checking the Test Results -- Pass / Fail
        Assert.AreEqual(50, result);

    }


    [Test]
    [TestCase(19)]
    [TestCase(20)]
    [TestCase(22)]
    public void OddNumber_Checker(int a)
    {

        // Arrange
        //Calculator cal = new();

        // Act

      bool isOdd= _calc.IsOddNumber(a);
        // Assert

        Assert.That(isOdd, Is.EqualTo(false));
    }


    // Combined Expected Result

    [Test]
    [TestCase(10,ExpectedResult =false)]
    [TestCase(11,ExpectedResult =false)]
    public bool OddNumber_Checker_Combined(int a )
    {
        // Arrange
        //Calculator cal3 = new();

        // Act
        return _calc.IsOddNumber(a);

        
    }


    [Test]
    public void OddRanger_InputMinAndMax_ReturnsValidOddNo()

    {

        // Arrange
       // Calculator _calc1 = new Calculator();
        List<int> expectedOddRange = new List<int>() { 5,7,9 };
        // Act
       List<int> result = _calc.GetOddRange(5,10);

        // Assert

       Assert.That(result, Is.Not.Empty);
        //Assert.That(result, Is.EquivalentTo(expectedOddRange));
       //Assert.AreEqual(expectedOddRange,result);
       // Assert.That(result, Does.Contain(7));
       // Assert.That(result, Is.Not.Empty);
       //Assert.That(result.Count, Is.EqualTo(3));
       // Assert.That(result, Has.No.Member(6));
       // Assert.That(result, Is.Ordered);
       // Assert.That(result, Is.Unique);
    }
}



