using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System;
using System.Collections.Generic;
using System.IO;

namespace ScriptureMemorizer
{
    /// <summary>
    /// Manages a collection of scriptures that can be loaded from files or predefined.
    /// </summary>
    public class ScriptureLibrary
    {
        private List<Scripture> _scriptures;
        private Random _random;

        /// Creates a new ScriptureLibrary with predefined scriptures.

        public ScriptureLibrary()
        {
            _scriptures = new List<Scripture>();
            _random = new Random();

            // Add some predefined scriptures
            _scriptures.Add(new Scripture("John 3:16", 
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
            
            _scriptures.Add(new Scripture("Proverbs 3:5-6", 
                "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));
            
            _scriptures.Add(new Scripture("Psalm 23:1", 
                "The Lord is my shepherd, I lack nothing."));
            
            _scriptures.Add(new Scripture("Matthew 5:14-16", 
                "You are the light of the world. A town built on a hill cannot be hidden. Neither do people light a lamp and put it under a bowl. Instead they put it on its stand, and it gives light to everyone in the house. In the same way, let your light shine before others, that they may see your good deeds and glorify your Father in heaven."));
        }

        /// Loads scriptures from a file.
        public void LoadFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                
                for (int i = 0; i < lines.Length; i += 2)
                {
                    if (i + 1 < lines.Length)
                    {
                        string reference = lines[i].Trim();
                        string text = lines[i + 1].Trim();
                        
                        if (!string.IsNullOrEmpty(reference) && !string.IsNullOrEmpty(text))
                        {
                            _scriptures.Add(new Scripture(reference, text));
                        }
                    }
                }
                
                Console.WriteLine($"Successfully loaded {_scriptures.Count} scriptures from file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading scriptures from file: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets a random scripture from the library.
        /// </summary>
        /// <returns>A random scripture</returns>
        public Scripture GetRandomScripture()
        {
            if (_scriptures.Count == 0)
            {
                throw new InvalidOperationException("No scriptures available in the library.");
            }
            
            int index = _random.Next(0, _scriptures.Count);
            return _scriptures[index];
        }

        /// <summary>
        /// Gets all scriptures in the library.
        /// </summary>
        /// <returns>A list of all scriptures</returns>
        public List<Scripture> GetAllScriptures()
        {
            return new List<Scripture>(_scriptures);
        }

        /// <summary>
        /// Adds a new scripture to the library.
        /// </summary>
        /// <param name="scripture">The scripture to add</param>
        public void AddScripture(Scripture scripture)
        {
            _scriptures.Add(scripture);
        }

        /// <summary>
        /// Gets the count of scriptures in the library.
        /// </summary>
        /// <returns>The number of scriptures</returns>
        public int Count()
        {
            return _scriptures.Count;
        }
    }
}
