namespace Calculations
{
  public class Calculations
  {
    public double DivideEvenly(string[] borrowers, double amountLent)
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