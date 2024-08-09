using System;

namespace basicProgram
{
    class Calculator{
        
        public double calculate(double first, double second, char op)
        {
            switch(op) // I did steal switch from C++ (as I'm also learning C++ and C# seems to be similar)
            {
                case '+':
                    return first + second;
                case '-':
                    return first - second;
                case '*':
                    return first * second;
                case '/':
                    return first / second;
                default:
                    Console.WriteLine("that's not a correct operator!");
                    return 0;
            }
        }
    }
}