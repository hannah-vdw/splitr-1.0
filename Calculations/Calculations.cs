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
        public static double DivideEvenly(string[] borrowers, double amountLent)
        {
            double costEach = Math.Round((amountLent / borrowers.Length), 2);

            if (costEach < 0.00)
            {
                throw new ArgumentException("Check how much you lent", nameof(amountLent));
            }

            return costEach;
        }
    }
}