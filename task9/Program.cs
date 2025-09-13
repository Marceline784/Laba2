using System;
  internal class Program
    {
        static void Main()
        {
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)('a' + i); 
        }
        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            //Знаходимо індекс цієї літери в масиві алфавіту
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (letter == alphabet[j])
                {
                    Console.WriteLine($"{letter} -> {j}");
                    break; // знайшли літеру, можемо виходити з внутрішнього циклу
                }
            }
        }
    }
    }

