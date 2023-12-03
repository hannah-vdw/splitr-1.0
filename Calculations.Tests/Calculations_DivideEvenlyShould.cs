using Xunit;
using Calculations;

namespace Calculations.Tests
{
    public class Calculations_DivideEvenlyShould
    {
        [Fact]
        public void ReturnsCorrectWholeNumber()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio"], 15);

            Assert.Equal(result, 5);
        }

        [Fact]
        public void RoundsDownTwoPlacesDecimal()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio"], 19);

            Assert.Equal(result, 6.33);
        }

        [Fact]
        public void RoundsUpTwoPlacesDecimal()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio", "Silvia"], 19.5);

            Assert.Equal(result, 4.88);
        }
        [Fact]
        public void GivenDecimalReturnsCorrectDecimal()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio", "Silvia"], 15.8);

            Assert.Equal(result, 3.95);
        }

        [Fact]
        public void GivenOneBorrowerReturnsOriginalLentAmount()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex"], 15.8);

            Assert.Equal(result, 15.8);
        }

        [Fact]
        public void SmallestReturnValueIs1p()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio", "Silvia", "Amy"], 0.05);

            Assert.Equal(result, 0.01);
        }

        [Fact]
        public void Returns0IsLentAmountLessThan1pPerBorrower()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio", "Silvia", "Amy"], 0.01);

            Assert.Equal(result, 0.00);
        }

        [Fact]
        public void GivenMinusNumberItThrowsCorrectException()
        {
            var calculations = new Calculations();

            var exception = Assert.Throws<ArgumentException>(() => calculations.DivideEvenly(["Alex", "Helen", "Fabio", "Silvia", "Amy"], -5));

            Assert.Equal("Check how much you lent (Parameter 'amountLent')", exception.Message);
        }
    }
}