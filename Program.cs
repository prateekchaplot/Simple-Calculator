using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ToNumber(Console.ReadLine());
                double secondNumber = inputConverter.ToNumber(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(firstNumber, secondNumber, operation);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                // TODO: start logging exceptions
                Console.WriteLine(ex.Message);
            }
        }
    }
}
