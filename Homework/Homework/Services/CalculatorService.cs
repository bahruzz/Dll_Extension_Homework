
namespace Homework.Services
{
    internal class CalculatorService
    {
        public double Calculator(double num1, double num2, string operation)
        {


            switch (operation)
            {
                case "+":
                    return num1 + num2;


                case "-":
                    return num1 - num2;


                case "*":
                    return num1 * num2;


                case "/":
                    return num1 / num2;


            }
            return 0;



        }
    }
}
