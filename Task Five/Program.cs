using System;

namespace TaskFour
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст");
            string input = Console.ReadLine();

            // символы, по которым будем разбивать слова
            char[] separators = { '.', ',', ' ', '-', '!', '?', ':', ';' };

            // разбиваем текст на слова
            string[] words = input.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // находим самые частовстречающиеся слова
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word] += 1;
                }
                else
                {
                    wordsCount[word] = 1;
                }
            }
            int maxCount = wordsCount.Values.Max();

            // считаем количество предложений 
            int sentences = 0;
            sentences += input.Count(c => c == '.');
            sentences += input.Count(c => c == '!');
            sentences += input.Count(c => c == '?');

            // находим среднюю длину слов
            int letters = words.Sum(w => w.Length);
            double wordsAverageLength = (double)letters / words.Length;

            // выводим полученные данные
            Console.WriteLine($"Количество слов: {words.Length}");
            Console.WriteLine($"Количество предложений: {sentences}");
            Console.WriteLine($"Средняя длина слов: {wordsAverageLength:F2}");
            Console.Write("Самые частовстречающиеся слова: ");
            foreach (var pair in wordsCount)
            {
                if (pair.Value == maxCount)
                {
                    Console.Write($"{pair.Key} ");
                }
            }
        }
    }
}