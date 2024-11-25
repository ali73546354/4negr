using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                string input1 = Console.ReadLine();
                int number1 = int.Parse(input1);

                Console.Write("Введите второе число: ");
                string input2 = Console.ReadLine();
                int number2 = int.Parse(input2);

                int result = DivideNumbers(number1, number2);
                Console.WriteLine($"Результат: {number1} / {number2} = {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите числовое значение.");
                Console.WriteLine($"Сообщение: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                Console.WriteLine($"Сообщение: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка.");
                Console.WriteLine($"Сообщение: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
        }

        static int DivideNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            return numerator / denominator;
        }
    }
}