using System;

namespace MiniCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());

                    double result = AddNumbers(firstNumber, secondNumber);

                    Console.WriteLine($"Сумма {firstNumber} и {secondNumber} равна {result}.");
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Пожалуйста, введите корректное число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Вычисление завершено.");
                }
            }
        }

        static double AddNumbers(double a, double b)
        {
            return a + b;
        }
    }
}