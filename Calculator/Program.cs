using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;
            var calculator = new Calculator();

            Console.WriteLine("Input Operator(+, -, *, /)");
            Console.Write("> ");
            var inputOperator = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Input Operand(If you want to exist, input exit)");
                Console.Write("> ");
                var inputNumber = Console.ReadLine();

                switch (inputNumber.Contains(","))
                {
                        
                }

                if (inputNumber != "exit")
                {
                    calculator.AddInput(Convert.ToInt32(inputNumber));
                }
                else
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }

    class Calculator
    {
        public enum Operator { Plus, Minus, Multiply, Divison }
        public int Number { get; set; }

        public void AddInput(int number)
        {
            number = number;

        }

        public int[] AddInputs(int[] numbers)
        {
            
            return numbers;
        }

        public void Calculate()
        {
            
        }
    }
}
