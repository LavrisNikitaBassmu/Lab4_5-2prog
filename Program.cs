using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        // Регулярное выражение для поиска слов, начинающихся с большой буквы и заканчивающихся на две цифры
        string pattern = @"\b[A-Z][a-zA-Z]*\d{2}\b";
        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine("Слова, начинающиеся с большой буквы и заканчивающиеся на две цифры:");

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}