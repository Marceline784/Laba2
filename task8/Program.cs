using System;
using System.Collections.Generic;
class Program
    {
        static void Main()
        {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("Enter numbers: ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
         
        int maxCount = 0;
        List<int> meetNum = new List<int>(); // список чисел, які зустрічаються max разів
        //Проходимо по кожному числу, щоб порахувати, скільки разів воно зустрічається
        for (int i = 0; i < n; i++)
        {
            int count = 0; // скільки разів поточне число зустрічається
            for (int j = 0; j < n; j++)
            {
                if (numbers[j] == numbers[i])
                {         
                    count++;
                }
            }
            // якщо поточне число зустрічається більше, ніж попереднє максимум
            if (count > maxCount)
            {
                maxCount = count; // оновлюємо максимальну частоту
                meetNum.Clear(); // очищаємо список, бо є новий максимум
                meetNum.Add(numbers[i]); // додаємо це число в список
            }
            else if (count == maxCount && !meetNum.Contains(numbers[i]))
            {
                meetNum.Add(numbers[i]);//Якщо число зустрічається так само часто, як максимум, і його ще немає в списку → додаємо
            }
        }
        //Знаходимо лівостороннє число серед тих, що зустрічаються найчастіше
        int leftMost = -1;
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < meetNum.Count; k++)
            {
                if (numbers[i] == meetNum[k])
                {
                    leftMost = numbers[i]; // перше зліва число
                    break;
                }
            }
            if (leftMost != -1) break; // зупиняємо, як тільки знайшли
        }
        Console.WriteLine($"Number {string.Join(", ", meetNum)} occurs most frequently ({maxCount} times)");
        Console.WriteLine($"Leftmost number – {leftMost}");
    }
}

