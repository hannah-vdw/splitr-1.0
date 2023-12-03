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
            double result = Calculations.DivideEvenly(borrowers.Length, 15);

            Assert.Equal(5, result);
        }

        [Fact]
        public void RoundsDownTwoPlacesDecimal()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio" };
            double result = Calculations.DivideEvenly(borrowers.Length, 19);

            Assert.Equal(6.33, result);
        }

        [Fact]
        public void RoundsUpTwoPlacesDecimal()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia" };
            double result = Calculations.DivideEvenly(borrowers.Length, 19.5);

            Assert.Equal(4.88, result);
        }
        [Fact]
        public void GivenDecimalReturnsCorrectDecimal()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia" };
            double result = Calculations.DivideEvenly(borrowers.Length, 15.8);

            Assert.Equal(3.95, result);
        }

        [Fact]
        public void GivenOneBorrowerReturnsOriginalLentAmount()
        {
            var borrowers = new string[] { "Alex" };
            double result = Calculations.DivideEvenly(borrowers.Length, 15.8);

            Assert.Equal(15.8, result);
        }

        [Fact]
        public void SmallestReturnValueIs1p()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia", "Amy" };
            double result = Calculations.DivideEvenly(borrowers.Length, 0.05);

            Assert.Equal(0.01, result);
        }

        [Fact]
        public void Returns0IsLentAmountLessThan1pPerBorrower()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia", "Amy" };
            double result = Calculations.DivideEvenly(borrowers.Length, 0.01);

            Assert.Equal(0.00, result);
        }

        [Fact]
        public void GivenMinusNumberItThrowsCorrectException()
        {
            var borrowers = new string[] { "Alex", "Helen", "Fabio", "Silvia", "Amy" };

            var exception = Assert.Throws<ArgumentException>(() => Calculations.DivideEvenly(borrowers.Length, -5));

            Assert.Equal("Check how much you lent (Parameter 'amountLent')", exception.Message);
        }
    }
}