using System;
using System.Collections.Generic;

Console.WriteLine("Select dictionary type:");
Console.WriteLine("1. English to Russian");
Console.WriteLine("2. Russian to English");

int choice = Convert.ToInt32(Console.ReadLine());

Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

if (choice == 1)
{
    
    AddToDictionary(dictionary, "apple", new List<string> { "яблоко", "апельсин" });
    AddToDictionary(dictionary, "cat", new List<string> { "кот" });
    AddToDictionary(dictionary, "dog", new List<string> { "собака" });
}
else if (choice == 2)
{
    
    AddToDictionary(dictionary, "яблоко", new List<string> { "apple", "orange" });
    AddToDictionary(dictionary, "кот", new List<string> { "cat" });
    AddToDictionary(dictionary, "собака", new List<string> { "dog" });
}
else
{
    Console.WriteLine("Invalid dictionary type selected.");
    return;
}

Console.WriteLine("Dictionary created.");
Console.WriteLine("Enter a word to translate (type 'exit' to quit):");

while (true)
{
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    if (input == "add")
    {
        Console.WriteLine("Enter a word to add:");
        string wordToAdd = Console.ReadLine();
        Console.WriteLine("Enter its translations separated by commas:");
        List<string> translationsToAdd = new List<string>(Console.ReadLine().Split(','));

        AddToDictionary(dictionary, wordToAdd, translationsToAdd);

        Console.WriteLine("Word and translations added to the dictionary.");
    }
    else if (input == "replace")
    {
        Console.WriteLine("Enter a word or translation to replace:");
        string wordToReplace = Console.ReadLine();
        Console.WriteLine("Enter its new translations separated by commas:");
        List<string> newTranslations = new List<string>(Console.ReadLine().Split(','));

        if (dictionary.ContainsKey(wordToReplace))
        {
            dictionary[wordToReplace] = newTranslations;
            Console.WriteLine("Word and translations replaced in the dictionary.");
        }
        else
        {
            Console.WriteLine("Word or translation not found in the dictionary.");
        }
    }
    else if (input == "delete")
    {
        Console.WriteLine("Enter a word or translation to delete:");
        string wordToDelete = Console.ReadLine();

        if (dictionary.ContainsKey(wordToDelete))
        {
            dictionary.Remove(wordToDelete);
            Console.WriteLine("Word and its translations deleted from the dictionary.");
        }
        else
        {
            bool removed = false;
            foreach (var key in dictionary.Keys.ToList())
            {
                if (dictionary[key].Contains(wordToDelete) && dictionary[key].Count > 1)
                {
                    dictionary[key].Remove(wordToDelete);
                    Console.WriteLine("Translation deleted from the dictionary.");
                    removed = true;
                    break;
                }
            }

            if (!removed)
            {
                Console.WriteLine("Word or translation not found in the dictionary or it's the last translation.");
            }
        }
    }
    else if (input == "translate")
    {
        Console.WriteLine("Enter a word to translate:");
        string wordToTranslate = Console.ReadLine();

        if (dictionary.ContainsKey(wordToTranslate))
        {
            Console.WriteLine($"Translations for '{wordToTranslate}':");
            foreach (var translation in dictionary[wordToTranslate])
            {
                Console.WriteLine($"- {translation}");
            }
        }
        else
        {
            Console.WriteLine("Word not found in the dictionary.");
        }
    }
    else
    {
        Console.WriteLine("Invalid command. Enter 'add' to add, 'replace' to replace, 'delete' to delete, or 'exit' to quit.");
    }
    
}

static void AddToDictionary(Dictionary<string, List<string>> dictionary, string word, List<string> translations)
{
    if (!dictionary.ContainsKey(word))
    {
        dictionary[word] = new List<string>();
    }

    foreach (var translation in translations)
    {
        dictionary[word].Add(translation);
    }
}