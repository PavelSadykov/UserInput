
using System;
using System.IO;
using System.Text.RegularExpressions;
namespace Задание__4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string numbers = GetNumbersFromString(input);
        string nonNumbers = GetNonNumbersFromString(input);

        Console.WriteLine("Строка с числами: " + numbers);
        Console.WriteLine("Строка с символами, не являющимися числами: " + nonNumbers);

        // Сохранение результатов в файл
        SaveStringToFile(numbers, "numbers.txt");
        SaveStringToFile(nonNumbers, "nonNumbers.txt");

        Console.WriteLine("Результаты сохранены в файлы numbers.txt и nonNumbers.txt.");
    }

    static string GetNumbersFromString(string input)
    {
        string numbers = "";

        foreach (char c in input)
        {
            if (Char.IsDigit(c))
            {
                numbers += c;
            }
        }

        return numbers;
    }

    static string GetNonNumbersFromString(string input)
    {
        string nonNumbers = "";

        foreach (char c in input)
        {
            if (!Char.IsDigit(c))
            {
                nonNumbers += c;
            }
        }

        return nonNumbers;
    }

    static void SaveStringToFile(string text, string filename)
    {
        File.WriteAllText(filename, text);
    }
}


