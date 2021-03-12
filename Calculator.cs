using System;

namespace Basic_Calculator
{
    public class Calculator 
    {
        public static double Addition(double firstValue, double secondValue)
        {
            double sum;
            sum = firstValue + secondValue;
            return Math.Round(sum, 2);  
        }

        public static double Subtraction(double firstValue, double secondValue)
        {
            double difference;
            difference = firstValue - secondValue;
            return Math.Round(difference, 2);  
        }

        public static double Multipliation(double firstValue, double secondValue)
        {
            double product;
            product = firstValue * secondValue;
            return Math.Round(product, 2);  
        }
        
        public static double Division(double firstValue, double secondValue)
        {
            double quotient;
            quotient = firstValue / secondValue;
            return Math.Round(quotient, 2);  
        }
            
    }
}

