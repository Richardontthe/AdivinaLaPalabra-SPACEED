using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaLaPalabraRicardoHernandez.GameLogicLayer
{
    internal class WordGenerator
    {
        FileHandler fileHandler = new FileHandler();
        Random random = new Random();

        /// <summary>
        /// Generates a random word from the list of words obtained from the FileHandler class.
        /// </summary>
        /// <returns></returns>
        public string GenerateWord()
        {
            List<string> words = fileHandler.getWords();
            return words[random.Next(words.Count)];
        }

        /// <summary>
        /// checks if a word exists in the list of words obtained from the FileHandler class.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool IsValidWord(string word)
        {
            List<string> words = fileHandler.getWords();
            return words.Contains(word.ToLower());
        }


    }
}
