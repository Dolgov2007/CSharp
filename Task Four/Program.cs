using System;

namespace TaskFour
{
    class Program
    {
        static void Main()
        {
            Console.Write("Пожалуйста, введите пароль: ");

            while (true)
            {
                string password = Console.ReadLine();
                if (password.Length > 8)
                {
                    if (password.Any(char.IsDigit))
                    {
                        if (password.Any(char.IsUpper))
                        {
                            if (password.Any(c => !char.IsLetterOrDigit(c)))
                            {
                                Console.WriteLine("Поздравляем! Ваш пароль сильный!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Нет специальных символов!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("В Вашем пароле нет заглавных букв");
                        }
                    }
                    else
                    {
                        Console.WriteLine("В Вашем пароле нет цифр!");
                    }
                }
                else
                {
                    Console.WriteLine("Длина меньше 8 символов!");
                }
            }
        }
    }
}