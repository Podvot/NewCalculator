using System.Data.SqlClient;

namespace NewCalculator
{
    public class Program
    {

        public static void Main(String[] args)
        {
            try
            {

                Console.WriteLine("Enter a number:");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a second number:");
                double n2 = Convert.ToDouble(Console.ReadLine());
        
                string connectionString = "MyConnectionString";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Calculator calculator = new Calculator(connection);
                    Console.WriteLine(
                        "Enter a method by writing coresponding number: 1. Add | 2. Subtract | 3. multiply | 4. Divide");
                    string method = Console.ReadLine();
                    if (method.Equals("1"))
                    {
                        calculator.Add(n1, n2);
                    }
                    else if (method.Equals("2"))
                    {
                        calculator.Subtract(n1, n2);
                    }
                    else if (method.Equals("3"))
                    {
                        calculator.Multiply(n1, n2);
                    }
                    else if (method.Equals("4"))
                    {
                        calculator.Divide(n1, n2);
                    }
                    connection.Close();
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);
            }
        }
    }
}