namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act 
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act 
            double result = _calculator.Subtract(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(-10));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiplication()
        {
            // Act 
            double result = _calculator.Multiply(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        //Qn13 ab (2 tests, affect times 0 as well)
        [Test]
        [TestCase(0, 10)]
        [TestCase(5, 0)]
        public void Multiply_WithZerosAsInputs_ResultZero(int a, int b)
        {
            // Assert
            Assert.That(() => _calculator.Multiply(a, b), Is.EqualTo(0));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivision()
        {
            // Act 
            double result = _calculator.Divide(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
        //Qn14 ab
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }
        //Qn 15 ab (2 tests)
        [Test]
        [TestCase(5)]
        public void Factorial_WithInput_ResultFact(int a)
        {
            Assert.That(() => _calculator.Factorial(a), Is.EqualTo(120));
        }
        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        public void Factorial_WithNegative_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }
        //Qn 16 ab
        [Test]
        public void Triangle_WithHeightAndLength_ResultArea()
        {
            // Act 
            double result = _calculator.TriangleArea(2, 3);
            // Assert
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Circle_WithRadius_ResultArea()
        {
            // Act 
            double result = _calculator.CircleArea(4);
            // Assert
            Assert.That(result, Is.EqualTo(50.272));
        }

        //Qn17 (Fibonacci, 
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act 
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act 
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        //17b
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act 
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act 
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
    }
}