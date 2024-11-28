using System;
public interface ILogger
{
    void LogInfo(string message);
    void LogError(string message);
}

public class ConsoleLogger : ILogger
{
    public void LogInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}

namespace MiniCalculator
{
    class Program
    {
        private static ILogger _logger;

        static void Main(string[] args)
        {
            _logger = new ConsoleLogger(); 

            while (true)
            {
                try
                {
                    _logger.LogInfo("Введите первое число: ");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());

                    _logger.LogInfo("Введите второе число: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());

                    double result = AddNumbers(firstNumber, secondNumber);

                    _logger.LogInfo($"Сумма {firstNumber} и {secondNumber} равна {result}.");
                    break; 
                }
                catch (FormatException)
                {
                    _logger.LogError("Ошибка: Пожалуйста, введите корректное число.");
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Произошла ошибка: {ex.Message}");
                }
                finally
                {
                    _logger.LogInfo("Вычисление завершено.");
                }
            }
        }

        static double AddNumbers(double a, double b)
        {
            return a + b;
        }
    }
}