using System;
using System.IO;

public class Program
{
    static void Main()
    {
        string filePath = "t.txt";

        try
        {
            int count = Count(filePath);

            Console.WriteLine($"Кількість слів, що починаються з букви 'b': {count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    public static int Count(string filePath)
    {
        string fileContent = File.ReadAllText(filePath);

        string[] words = fileContent.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        int count = 0;

        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word) && word[0] == 'b' || word[0] == 'B')
            {
                count++;
            }
        }

        return count;
    }
}