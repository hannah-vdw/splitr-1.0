namespace Calculations
{
    public class Calculations
    {
        /// <summary>
        /// Divide Evenly can be a static method as it does not rely on any state in this class. 
        /// </summary>
        /// <param name="borrowers"></param>
        /// <param name="amountLent"></param>
        /// <returns>The amount each person owes when the total is equaly split</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double DivideEvenly(int numberOfBorrowers, double amountLent) // Rather than passing all of the borrowers names, we should only pass the number of borrowers. This is all that is required for this to work so we don't need the extra data here. Any more is a conflation of concerns. 
        {
            double costEach = Math.Round((amountLent / numberOfBorrowers), 2);

            if (costEach < 0.00)
            {
                throw new ArgumentException("Check how much you lent", nameof(amountLent));
            }

            return costEach;
        }
    }
}