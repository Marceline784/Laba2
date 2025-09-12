using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 1 sentences: ");
        string input1 = Console.ReadLine();
        string[] words1 = input1.Split(" ");

        Console.WriteLine("Enter 2 sentences: ");
        string input2 = Console.ReadLine();
        string[] words2 = input2.Split(" ");

        // Знаходимо мінімальну довжину обох масивів слів,
        // щоб не виходити за межі під час перевірки
        int minlength = Math.Min(words1.Length, words2.Length);
        int leftCount = 0;
        int rightCount = 0;
        // Перевіряємо спільні слова зліва (початок речення)
        for (int i = 0; i < minlength; i++)
        {

            if (words1[i] == words2[i])
            {
                leftCount++; // знайшли спільне слово
            }
            else
                break; // якщо слова різні — зупиняємо перевірку
        }
        // Перевіряємо спільні слова справа (кінець речення)
        for (int i = 0; i < minlength; i++)
        {

            if (words1[words1.Length - 1 - i] == words2[words2.Length - 1 - i])
            {
                rightCount++; // знайшли спільне слово
            }
            else 
                break;

        }
        if (leftCount == 0 && rightCount == 0)
        {
            Console.WriteLine("No common words at the left and right");
        } else if (leftCount > 0)
        {
            Console.WriteLine($"The largest common end is at the left: {leftCount}");
        } else
        {
            Console.WriteLine($"The largest common end is at the right: {rightCount}");
        }
    }
}
