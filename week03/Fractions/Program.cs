using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorization
{
    // Class to represent a single word in the scripture
    public class Word
    {
        public string Text { get; private set; }
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public string Display()
        {
            return IsHidden ? new string('_', Text.Length) : Text;
        }
    }

    // Class to represent the scripture reference
    public class Reference
    {
        public string ReferenceText { get; private set; }

        public Reference(string reference)
        {
            ReferenceText = reference;
        }

        public override string ToString()
        {
            return ReferenceText;
        }
    }

    // Class to represent the scripture itself
    public class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Word> Words { get; set; }

        public Scripture(string reference, string text)
        {
            Reference = new Reference(reference);
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public string Display()
        {
            return $"{Reference}\n" + string.Join(" ", Words.Select(word => word.Display()));
        }

        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(Words.Count);
            Words[index].Hide();
        }

        public bool AllWordsHidden()
        {
            return Words.All(word => word.IsHidden);
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son");

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.Display());
                Console.WriteLine("Press Enter to hide a word or type 'quit' to exit: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWord();

                if (scripture.AllWordsHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.Display());
                    Console.WriteLine("All words are hidden. Exiting the program.");
                    break;
                }
            }
        }
    }
}
}