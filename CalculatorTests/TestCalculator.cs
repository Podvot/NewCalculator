using NewCalculator;

namespace CalculatorTests;

public class TestCalculator : ICalculator
{
    public double Add(double n1, double n2)
            {
                double total = n1 + n2;
                if (total > 2147483646 || total < -2147483647)
                {
                    throw new OverflowException("Number is out of range");
                }
    
                Console.WriteLine($"Result is: {total}", total);
                
                return total;
            }
            public double Subtract(double n1, double n2)
            {
                double total = n1 - n2;
                if (total > 2147483646 || total < -2147483647)
                {
                    throw new OverflowException("Number is out of range");
                }
    
                Console.WriteLine($"Result is: {total}", total);
                
                return total;
            }
            public double Multiply(double n1, double n2)
            {
                double total = n1 * n2;
                if (total > 2147483646 || total < -2147483647)
                {
                    throw new OverflowException("Number is out of range");
                }
    
                Console.WriteLine($"Result is: {total}", total);
                
                return total;
            }
            public double Divide(Double n1, Double n2)
            {
                double total = n1 / n2;
                if (n1 == 0)
                {
                    throw new DivideByZeroException("Can't divide by zero");
                }
    
                Console.WriteLine($"Result is: {total}", total);
                
                return total;
            }
}