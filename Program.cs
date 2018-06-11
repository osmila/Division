using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerator, denumerator, resultOfDivision;
            StreamReader sr;

            try
            {
                sr = new StreamReader("data.txt");
            }
            catch (FileNotFoundException notFountEx)
            {
                Console.WriteLine(notFountEx.Message);
                Console.ReadKey();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }

            try
            {
                numerator = Double.Parse(sr.ReadLine());
                denumerator = Double.Parse(sr.ReadToEnd());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Check the data in your file. It doesn't contain 2 numbers.");
                Console.ReadKey();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("One of the numbers wasn't double.");
                Console.ReadKey();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }

            try
            {
                resultOfDivision = ArithmeticOperation.Divide(numerator, denumerator);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denumerator is equal to zero. It's forbidden.");
                Console.ReadKey();
                return;
            }

            StreamWriter sw = new StreamWriter("result.txt", true);
            sw.WriteLine("Result of division {0} by {1} is {2}.", numerator, denumerator, resultOfDivision);
            sw.Close();
            Console.WriteLine("Success! Check the file with result.");
            Console.ReadKey();
        }
    }
}
