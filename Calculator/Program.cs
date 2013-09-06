using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = null;
            var reg = new Regex(",*[0-9]*");

            inputAgain:
            Console.WriteLine("Input Operator(+, -, *, /)");
            Console.Write("> ");
            
            var inputOperator = Console.ReadLine();
            switch (inputOperator)
            {
                case "+":
                    calculator = new Calculator(OperatorType.Plus);
                    break;
                case "-":
                    calculator = new Calculator(OperatorType.Minus);
                    break;
                case "*":
                    calculator = new Calculator(OperatorType.Multiply);
                    break;
                case "/":
                    calculator = new Calculator(OperatorType.Divison);
                    break;
                default :
                    goto inputAgain;
                    break;
            }

            while (true)
            {
                Console.WriteLine("Input Operand(If you want to exist, input exit)");
                Console.Write("> ");
                var inputNumber = Console.ReadLine();

                if (inputNumber != null && (inputNumber != "exit" && !inputNumber.Contains(",")))
                {
                    calculator.AddInput(Convert.ToInt32(inputNumber));
                }
                else if (inputNumber != null && inputNumber.Contains(","))
                {
                    var sp = inputNumber.Split(new char[] {','});
                    var numArr = new int[sp.Length];
                    for (var i = 0; i < sp.Length; i++)
                    {
                        numArr[i] = Convert.ToInt32(sp[i]);
                    }
                    calculator.AddInputs(numArr);
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("> Result : "+"{0} = {1}",calculator,calculator.Calculate());

            Console.ReadKey();
        }
    }

    public enum OperatorType { Plus, Minus, Multiply, Divison }

    class Calculator
    {
        private List<int> operands = new List<int>();

        public OperatorType Operator { get; private set; }

        public Calculator(OperatorType op)
        {
            Operator = op;
        }

        public void AddInput(int number)
        {
            operands.Add(number);
        }

        public void AddInputs(int[] numbers)
        {
            operands.AddRange(numbers);
        }

        public int Calculate()
        {
            var result = operands.First();
            switch (Operator)
            {
                case OperatorType.Plus:
                    foreach (var i in operands.Skip(1))
                    {
                        result = result + i;
                    }
                    break;
                case OperatorType.Minus:
                    foreach (var i in operands.Skip(1))
                        result = result - i;
                    break;
                case OperatorType.Multiply:
                    foreach (var i in operands.Skip(1))
                    {
                        result = result * i;
                    }
                    break;
                case OperatorType.Divison:
                    foreach (var i in operands.Skip(1))
                    {
                        result = result / i;
                    }
                    break;
            }
            return result;
        }

        public override string ToString()
        {
            var separater = "";

            switch (Operator)
            {
                case OperatorType.Plus:
                    separater = "+";
                    break;
                case OperatorType.Minus:
                    separater = "-";
                    break;
                case OperatorType.Multiply:
                    separater = "*";
                    break;
                case OperatorType.Divison:
                    separater = "/";
                    break;
            }

            return String.Join(separater,operands);

        }
    }
}
