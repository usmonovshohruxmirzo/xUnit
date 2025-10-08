using TestProject.Core;
using Xunit.Abstractions;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        private readonly ITestOutputHelper _output;
        private readonly Calculator calculator;

        public CalculatorTests(ITestOutputHelper output)
        {

             calculator = new Calculator();
            _output = output;
        }

        [Fact]
        [Trait("Category", "Math")]
        [Trait("Priority", "High")]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            var result = calculator.Add(2, 3);

            _output.WriteLine("Description: Verifying Add method with inputs 2 and 3");
            Assert.Equal(5, result);
        }

        [Fact]
        [Trait("Category", "Math")]
        public void Substract_Two_Numbers_Returns_Sum()
        {
          var result = calculator.Substract(10, 5);

          _output.WriteLine("Description: Verifying Substract method with inputs 10 and 5");
          Assert.Equal(5, result);
        }

        [Fact]
        [Trait("Category", "Math")]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
          _output.WriteLine("Description: Verifying DivideByZeroException");
          Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
