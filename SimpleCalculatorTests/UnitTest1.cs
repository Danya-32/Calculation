namespace SimpleCalculatorTests
{
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

    }