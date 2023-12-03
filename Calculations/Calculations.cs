namespace Calculations
{
    public class Calculations
    {
        /// <summary>
        /// Divide Evenly can be a static method as it does not rely on any state in this class. 
        /// </summary>
        /// <param name="numberOfBorrowers">The number of people who borrowed. This must be a positive integer.</param>
        /// <param name="amountLent">The amount lent to be devided. This must be zero or greater.</param>
        /// <returns>The amount each person owes when the total is equaly split</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double DivideEvenly(int numberOfBorrowers, double amountLent) // Rather than passing all of the borrowers names, we should only pass the number of borrowers. This is all that is required for this to work so we don't need the extra data here. Any more is a conflation of concerns. 
        {
            // Protect from a devide by zero exception with a more descriptive exception
            if (numberOfBorrowers < 1)
            {
                throw new ArgumentException("Number of borrowers must be a postive integer", nameof(numberOfBorrowers));
            }

            // Protect from negative debt - this would not cause an exception, but could lead to unexpected behavior - fail early. 
            if (amountLent < 0)
            {
                throw new ArgumentException("A negative amount can not be lent", nameof(amountLent));
            }

            double costEach = Math.Round((amountLent / numberOfBorrowers), 2);

            return costEach;
        }
    }
}