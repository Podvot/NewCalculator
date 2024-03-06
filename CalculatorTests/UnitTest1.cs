using System.Data.SqlClient;

namespace CalculatorTests;


public class Tests
{
    TestCalculator calculator = new TestCalculator();
    
    [Test]
    public void Add()
    {
        double n1 = 2;
        double n2 = 2;
        double total = 4;
        
        Assert.That(calculator.Add(n1, n2).Equals(total));

    }
    
    [Test]
    public void Subtract()
    {
        double n1 = 5;
        double n2 = 2;
        double total = 3;
        
        Assert.That(calculator.Subtract(n1, n2).Equals(total));

    }
    
    [Test]
    public void Multiply()
    {
        double n1 = 4;
        double n2 = 3;
        double total = 12;
        
        Assert.That(calculator.Multiply(n1, n2).Equals(total));

    }
    
    [Test]
    public void Divide()
    {
        double n1 = 10;
        double n2 = 2;
        double total = 5;
        
        Assert.That(calculator.Divide(n1, n2).Equals(total));

    }
    
}