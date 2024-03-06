using System.Data.SqlClient;

namespace NewCalculator
{
    public class Calculator : ICalculator
    {
        private readonly SqlConnection connectionString;
        public Calculator(SqlConnection connection)
        {
            connectionString = connection;
        }
        public double Add(double n1, double n2)
        {
            double total = n1 + n2;
            if (total > 2147483646 || total < -2147483647)
            {
                throw new OverflowException("Number is out of range");
            }

            Console.WriteLine($"Result is: {total}", total);

            History(n1, "+", n2, total);

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

            History(n1, "-", n2, total);

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

            History(n1, "*", n2, total);

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

            History(n1, "/", n2, total);

            return total;
        }
        public bool History(double n1, string method, double n2, double total)
        {
            string queryData =
                "INSERT INTO calculatedNumbers (n1, method, n2, total) VALUES (@FirstNr1, @Method2, @SecondNr3, @Total4)";

            using (SqlCommand command = new SqlCommand(queryData, connectionString))
            {
                command.Parameters.AddWithValue("@FirstNr1", n1);
                command.Parameters.AddWithValue("@Method2", method);
                command.Parameters.AddWithValue("@SecondNr3", n2);
                command.Parameters.AddWithValue("@Total4", total);
                int dataInserted = command.ExecuteNonQuery();

                return dataInserted > 0;
            }
        }

    }
}