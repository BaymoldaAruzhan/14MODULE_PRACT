using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Module_practic
{
    internal class Program
    {
        static void Main()
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            DisplayWordStatistics(text);
        }

        // Метод для подсчета количества вхождений каждого слова в текст
        static Dictionary<string, int> CountWordOccurrences(string text)
        {
            // Разделяем текст на слова
            string[] words = text.Split(new[] { ' ', '.', ',', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Инициализируем словарь для хранения статистики
            Dictionary<string, int> wordOccurrences = new Dictionary<string, int>();

            // Подсчитываем вхождения каждого слова
            foreach (var word in words)
            {
                // Приводим слово к нижнему регистру для учета регистра
                string cleanedWord = word.ToLower();

                // Если слово уже встречалось, увеличиваем счетчик, иначе добавляем в словарь
                if (wordOccurrences.ContainsKey(cleanedWord))
                {
                    wordOccurrences[cleanedWord]++;
                }
                else
                {
                    wordOccurrences[cleanedWord] = 1;
                }
            }

            return wordOccurrences;
        }

        // Метод для отображения статистики слов в виде таблицы
        static void DisplayWordStatistics(string text)
        {
            // Подсчитываем статистику слов в тексте
            Dictionary<string, int> wordStatistics = CountWordOccurrences(text);

            // Выводим статистику в виде таблицы
            Console.WriteLine("Слово\t\tКоличество");
            Console.WriteLine("------------------------");
            foreach (var entry in wordStatistics)
            {
                Console.WriteLine($"{entry.Key,-15}{entry.Value}");
            }
        }
    }
}
