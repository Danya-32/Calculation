using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void TestAddition()
    {
        var result = calculator.PerformOperation("+", 1, 2);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void TestSubtraction()
    {
        var result = calculator.PerformOperation("-", 5, 3);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void TestMultiplication()
    {
        var result = calculator.PerformOperation("*", 3, 4);
        Assert.AreEqual(12, result);
    }

    [Test]
    public void TestDivision()
    {
        var result = calculator.PerformOperation("/", 10, 2);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void TestDivisionByZero()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.PerformOperation("/", 1, 0));
    }

    [Test]
    public void TestModulus()
    {
        var result = calculator.PerformOperation("%", 10, 3);
        Assert.AreEqual(1, result);
    }

    [Test]
    public void TestPower()
    {
        var result = calculator.PerformOperation("^", 2, 3);
        Assert.AreEqual(8, result);
    }

    [Test]
    public void TestSqrt()
    {
        var result = calculator.Sqrt(16);
        Assert.AreEqual(4, result);
    }

    [Test]
    public void TestSin()
    {
        var result = calculator.Sin(Math.PI / 2);
        Assert.AreEqual(1, result, 0.0001);
    }

    [Test]
    public void TestCos()
    {
        var result = calculator.Cos(0);
        Assert.AreEqual(1, result, 0.0001);
    }

    [Test]
    public void TestFloor()
    {
        var result = calculator.Floor(3.7);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void TestCeil()
    {
        var result = calculator.Ceil(3.1);
        Assert.AreEqual(4, result);
    }

    [Test]
    public void TestMemoryAdd()
    {
        calculator.MemoryAdd(10);
        Assert.AreEqual(10, calculator.Memory);
    }

    [Test]
    public void TestMemoryClear()
    {
        calculator.MemoryAdd(10);
        calculator.MemoryClear();
        Assert.AreEqual(0, calculator.Memory);
    }

    [Test]
    public void TestMemoryRecall()
    {
        calculator.MemoryAdd(5);
        Assert.AreEqual(5, calculator.MemoryRecall());
    }
}
