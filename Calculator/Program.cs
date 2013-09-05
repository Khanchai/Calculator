using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var plus = Calculator.Operator.Plus;
            var minus = Calculator.Operator.Minus;
            var multiply = Calculator.Operator.Multiply;
            var divison = Calculator.Operator.Divison;

            var listNumber = new List<int>();

            Console.WriteLine("Input Operator(+, -, *, /)");
            Console.Write("> ");
            var inputOperator = Console.ReadLine();


            while (true)
            {
                Console.WriteLine("Input Operand(If you want to exist, input exit)");
                Console.Write("> ");
                var inputNumber = Console.ReadLine();

               if(inputNumber != "exit")
                {
                    if (inputNumber != null && inputNumber.Contains(","))
                    {
//                        calculator.AddInputs();
                    }
                    else  
                    {
                        calculator.AddInput(Convert.ToInt32(inputNumber));
                    }
                }

//                if (inputNumber != "exit")
//                {
//                    calculator.AddInput(Convert.ToInt32(inputNumber));
//                }
//                else
//                {
//                    break;
//                }
            }
         
            Console.ReadKey();
        }
    }

    class Calculator
    {
        public enum Operator { Plus, Minus, Multiply, Divison }

        public void AddInput(int number)
        {

        }

        public void AddInputs(int[] numbers)
        {

        }

        public void Calculate()
        {

        }
        
    }
}
