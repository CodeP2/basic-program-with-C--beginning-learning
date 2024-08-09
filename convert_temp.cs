using System;

namespace basicProgram
{
    class Convert
    {
        public string ConvertTemp(char op, double tempValue)
        {
            if(op=='C' || op=='c'){
                return $"Temperature from Fahrenheit to Celsius is: {(tempValue - 32) / 1.8} C";
            }
            else if(op=='F' || op=='f'){
                return $"Temperature from Celsius to Fahrenheit is: {(tempValue + 32) * 1.8} F";
            }
            else{
                return $"Incorrect operator: {op} or a temperature value: {tempValue}";
            }
        }
    }
}