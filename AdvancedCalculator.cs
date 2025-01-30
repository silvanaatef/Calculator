namespace OOPCalculator
{
    // Inheriting from the base class
    public class AdvancedCalculator : Calculator
    {
        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Cannot calculate the square root of a negative number");
            }
            return Math.Sqrt(a);
        }

        // Correcting Add to reflect proper addition
        public override double Add(double a, double b) => a + b;

        // Correcting Subtract to reflect proper subtraction
        public double Subtract(double a, double b) => a - b;
    }
}
