using System;

namespace TaskOne
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();

            Console.WriteLine("Попробуйте угадать число от 1 до 10");

            int rnd = random.Next(11);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num == rnd)
                    {
                        Console.WriteLine($"Вы угадали! Загаданное число: {rnd}");
                        break;
                    }
                    else
                    {
                        Console.Write("Нет! ");
                        if (num > rnd) Console.WriteLine("Загаданное число меньше");
                        else Console.WriteLine("Загаданное число больше");
                    }
                }
            }
        }
    }
}