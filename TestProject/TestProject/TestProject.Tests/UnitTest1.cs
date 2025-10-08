using TestProject.Core;
using Xunit.Abstractions;

namespace TestProject
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
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            var result = calculator.Add(2, 3);

            _output.WriteLine("Description: Verifying Add method with inputs 2 and 3");
            Assert.Equal(5, result);
        }

        [Fact]
        public void Substract_Two_Numbers_Returns_Sum()
        {
          var result = calculator.Divide(10, 5);
          Assert.Equal(5, result);
        }
    }
}
