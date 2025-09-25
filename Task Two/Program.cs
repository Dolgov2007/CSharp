using System;

namespace TaskOne
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nВводите числа, чтобы увидеть их сумму");
            Console.WriteLine("Введите ноль, чтобы закончить");
            int sum = 0;

            while (true)
            {
                Console.WriteLine("\nВведите число: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num == 0) break;
                    sum += num;
                    Console.WriteLine($"\nТекущая сумма: {sum}");

                }
                else
                {
                    Console.WriteLine("\nОшибка ввода!");
                }
            }
        }
    }
}