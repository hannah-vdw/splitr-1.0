using Xunit;
using Calculations;

namespace Calculations.Tests
{
    public class Calculations_DivideEvenlyShould
    {
        [Fact]
        public void ReturnsCorrectWholeNumber()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio" };
            var result = Calculations.DivideEvenly(borrowers.Length, 15);

            Assert.Equal(5, result);
        }

        [Fact]
        public void RoundsDownTwoPlacesDecimal()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio" };
            var result = Calculations.DivideEvenly(borrowers.Length, 19);

            Assert.Equal(6.33m, result);
        }

        [Fact]
        public void RoundsUpTwoPlacesDecimal()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia" };
            var result = Calculations.DivideEvenly(borrowers.Length, 19.5m);

            Assert.Equal(4.88m, result);
        }
        [Fact]
        public void GivenDecimalReturnsCorrectDecimal()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia" };
            var result = Calculations.DivideEvenly(borrowers.Length, 15.8m);

            Assert.Equal(3.95m, result);
        }

        [Fact]
        public void GivenOneBorrowerReturnsOriginalLentAmount()
        {
            var borrowers = new string[] { "Alex" };
            var result = Calculations.DivideEvenly(borrowers.Length, 15.8m);

            Assert.Equal(15.8m, result);
        }

        [Fact]
        public void SmallestReturnValueIs1p()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia", "Amy" };
            var result = Calculations.DivideEvenly(borrowers.Length, 0.05m);

            Assert.Equal(0.01m, result);
        }

        [Fact]
        public void Returns0IsLentAmountLessThan1pPerBorrower()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia", "Amy" };
            var result = Calculations.DivideEvenly(borrowers.Length, 0.01m);

            Assert.Equal(0.00m, result);
        }

        [Fact]
        public void GivenMinusNumberItThrowsCorrectException()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia", "Amy" };

            var exception = Assert.Throws<ArgumentException>(() => Calculations.DivideEvenly(borrowers.Length, -5));

            Assert.Equal("A negative amount can not be lent (Parameter 'amountLent')", exception.Message);
        }
    }
}