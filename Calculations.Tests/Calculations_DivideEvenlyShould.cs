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

            Assert.Equal(5, result);
        }

        [Fact]
        public void RoundsDownTwoPlacesDecimal()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio"], 19);

            Assert.Equal(6.33, result);
        }

        [Fact]
        public void RoundsUpTwoPlacesDecimal()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio", "Silvia"], 19.5);

            Assert.Equal(4.88, result);
        }
        [Fact]
        public void GivenDecimalReturnsCorrectDecimal()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio", "Silvia"], 15.8);

            Assert.Equal(3.95, result);
        }

        [Fact]
        public void GivenOneBorrowerReturnsOriginalLentAmount()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex"], 15.8);

            Assert.Equal(15.8, result);
        }

        [Fact]
        public void SmallestReturnValueIs1p()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio", "Silvia", "Amy"], 0.05);

            Assert.Equal(0.01, result);
        }

        [Fact]
        public void Returns0IsLentAmountLessThan1pPerBorrower()
        {
            var calculations = new Calculations();
            double result = calculations.DivideEvenly(["Alex", "Helen", "Fabio", "Silvia", "Amy"], 0.01);

            Assert.Equal(0.00, result);
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