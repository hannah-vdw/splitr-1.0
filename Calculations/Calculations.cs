namespace Calculations
{
  public class Calculations
  {
    public double DivideEvenly(string[] borrowers, double amountLent)
    {
      double costEach = Math.Round((amountLent / borrowers.Length), 2);

      if (costEach < 0.00)
      {
        throw new ArgumentException("Amount lent must be more than 0", nameof(amountLent));
      }

      return costEach;
    }
  }
}