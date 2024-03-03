using Homework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Controllers
{
    internal class Controller
    {
        CalculatorService CalculatorService;

        public Controller()
        {
            CalculatorService = new CalculatorService();

        }
        public void Calculator()
        {
            Console.WriteLine("Add num1");
            double num1=double.Parse(Console.ReadLine());
            Console.WriteLine("Add num2");
            double num2=double.Parse(Console.ReadLine());
            Console.WriteLine("Select operation");
            string operation=Console.ReadLine();


            Console.WriteLine(CalculatorService.Calculator(num1,num2,operation));
        }




    }
}

