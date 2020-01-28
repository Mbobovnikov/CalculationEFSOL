using System;
using System.Linq;

namespace calc2020
{
    class Program
    {
        public static double Summation(double firstTerm, double SecondTerm )
        {
            double outNum = firstTerm + SecondTerm;
            return outNum;
        }

        public static double Division(double firstTerm, double SecondTerm)
        {
            double outNum = firstTerm / SecondTerm;
            return outNum;
        }
        public static double Multiplicationn(double firstTerm, double SecondTerm)
        {
            double outNum = firstTerm * SecondTerm;
            return outNum;
        }
        public static double Subtraction(double firstTerm, double SecondTerm)
        {
            double outNum = firstTerm - SecondTerm;
            return outNum;
        }

        static void Main(string[] args)
        {


            ConsoleKeyInfo key;
            string matExpression = "";
            while (true)
            {
                Console.WriteLine("Введите выражение:");

                while (true)
                {
                    key = Console.ReadKey(true);

                    if (char.IsDigit(key.KeyChar))
                    {
                        Console.Write(key.KeyChar);
                        matExpression = matExpression + key.KeyChar;
                    }

                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        Console.Write(key.KeyChar + " " + key.KeyChar);
                        int count = matExpression.Length - 1;
                        matExpression = matExpression.Remove(count);
                    }

                    else if (key.KeyChar == '+' || key.KeyChar == '-' || key.KeyChar == '*' || key.KeyChar == '/' || key.KeyChar == '.' || key.KeyChar == ',')
                    {
                        if (key.KeyChar == ',')
                        {
                            Console.Write('.');
                            matExpression = matExpression + '.';
                        }
                        else
                        {
                            Console.Write(key.KeyChar);
                            matExpression = matExpression + key.KeyChar;
                        }                      
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }

                Console.WriteLine(); //Декоративный перенос 

                string[] arrayExpression = matExpression.Split('/', '+', '-', '*');
                
                double firstNum = Convert.ToDouble(arrayExpression[0]);
                double secondNum = Convert.ToDouble(arrayExpression[1]);

                bool multiplication = matExpression.Contains('*');
                bool division = matExpression.Contains('/');
                bool sum = matExpression.Contains('+');
                bool subtraction = matExpression.Contains('-');



                if (division)
                {
                    Console.WriteLine(Division(firstNum, secondNum));

                }
                else if (multiplication)
                {
                    Console.WriteLine(Multiplicationn(firstNum, secondNum));
                }
                else if (sum)
                {
                    Console.WriteLine(Summation(firstNum, secondNum));

                }
                else if (subtraction)
                {
                    Console.WriteLine(Subtraction(firstNum, secondNum));
                }
                else
                {
                    Console.WriteLine(matExpression);
                }
                matExpression = "";


            }

        }

            
            
        
    }
}
