using System;

namespace TaskOne
{
    class Program
    {
        static void Main()
        {
            Console.Write("Пожалуйста, введите температуру в градусах Цельсия: ");

            if (int.TryParse(Console.ReadLine(), out int celsius))
            {
                int fahrenheit = (int)(celsius * 1.8) + 32; 
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else
            {
                Console.WriteLine("Ошибка ввода!");   
            }
        }
    }
}