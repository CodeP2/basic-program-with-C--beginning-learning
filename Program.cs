using System;
using System.ComponentModel.Design;

namespace basicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            char operatorChar;

            Console.WriteLine("What is the 1st number? ");
            string inputNumber1 = Console.ReadLine();
            Console.WriteLine("What is the second number? ");
            string inputNumber2 = Console.ReadLine();
            Console.WriteLine("What is the operator? ");
            string operatorInput = Console.ReadLine();

            firstNumber = double.Parse(inputNumber1);
            secondNumber = double.Parse(inputNumber2);
            operatorChar = char.Parse(operatorInput);

            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.calculate(firstNumber, secondNumber, operatorChar));

            double tempValue;
            char tempOperator;

            Console.WriteLine("What is the temparature value you would like to convert?");
            string tempString = Console.ReadLine();
            Console.WriteLine("What would you like to convert it to? (correct options: F or C)");
            string tempOperatorString = Console.ReadLine();

            tempValue = double.Parse(tempString);
            tempOperator = char.Parse(tempOperatorString);

            Convert convertTemp = new Convert();

            Console.WriteLine(convertTemp.ConvertTemp(tempOperator, tempValue));


            string newString;

            Console.WriteLine("Type anything or not and see what happens!");
            newString = Console.ReadLine();

            BasicCheck check = new BasicCheck();

            Console.WriteLine(check.checkMe(newString));

            Console.WriteLine("So basic not even while loop or anything here");
        }
    }
}