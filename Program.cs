using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue;
            double secondValue;
            char optionYes = 'Y';
            while(optionYes == 'Y')
            {
                //Select the arithmetic operation you intend to perform
                Console.WriteLine(" <=========  CALCULATOR ==========> ");
                Console.WriteLine("Press any of the following key to perform an arithmetic operation:");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multipliation");
                Console.WriteLine("4 - Division");
                Console.WriteLine(" ");  

                var canConvertInput = Int32.TryParse(Console.ReadLine(), out int inputNumber);
                if(!canConvertInput || inputNumber == 0 || inputNumber > 4 )
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Select from the available keys. Try again!");
                    Console.WriteLine(" ");
                    continue;
                }

                // Enter the first and second value
                Console.Write("Enter Value 1: ");
                try
                {
                    firstValue = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.Exception)
                {   
                    Console.WriteLine("Invalid input format. Start all over!");
                    Console.WriteLine(" ");
                    continue;
                }
                
                Console.Write("Enter Value 2: ");
                try
                {
                    secondValue = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.Exception)
                {   
                    Console.WriteLine("Invalid input format. Start all over!");
                    Console.WriteLine(" ");
                    continue;
                }

                Console.WriteLine(" ");
                switch (inputNumber)
                {   
                    case 1:
                        Console.WriteLine($"{firstValue} + {secondValue} = {Calculator.Addition(firstValue, secondValue)}");
                    break;

                    case 2:
                        Console.WriteLine($"{firstValue} - {secondValue} = {Calculator.Subtraction(firstValue, secondValue)}");

                    break;

                    case 3:
                        Console.WriteLine($"{firstValue} x {secondValue} = {Calculator.Multipliation(firstValue, secondValue)}");
                    break;
    
                    default:
                        Console.WriteLine($"{firstValue} / {secondValue} = {Calculator.Division(firstValue, secondValue)}");
                    break;
                }

                Console.WriteLine(" ");
                Console.WriteLine("Do you want to continue again (Y/N)?");
                try
                {
                    char options = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    if(options == 'N')
                    {
                        optionYes = 'N';
                        return;
                    }
                    else if (options == 'Y') 
                    {
                        Console.WriteLine(" ");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Invalid input format!");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
