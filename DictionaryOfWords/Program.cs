using System;
using System.Collections.Generic;

namespace DictionaryOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */

            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Indeed", "used as an expression of surprise, incredulity, irony, etc.");
            wordsAndDefinitions.Add("Cat", "a small dometicated carnivore");
            wordsAndDefinitions.Add("Serendipity", "an aptitude for making desirable discoveries by accident");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Indeed"]);
            Console.WriteLine(wordsAndDefinitions["Cat"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            Console.WriteLine("");
            Console.WriteLine("---- Full Dictionary Below -----");

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is \"{word.Value}\"");
            }

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();
            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence
            */
            // Example of one dictionary in the list:
            // {
            //     "word": "excited",
            //     "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
            //     "part of speech": "adjective",
            //     "example sentence": "I am excited to learn C#!"
            // }

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("Word", "Excited");
            excitedWord.Add("Definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("Part of speech", "adjective");
            excitedWord.Add("Example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> indeedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            indeedWord.Add("Word", "Indeed");
            indeedWord.Add("Definition", "used as an expression of surprise, incredulity, irony, etc.");
            indeedWord.Add("Part of speech", "interjection");
            indeedWord.Add("Example sentence", "I am indeed excited to learn C#!");

            dictionaryOfWords.Add(indeedWord);

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                Console.WriteLine("------------------------");
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            };
        }
    }
}