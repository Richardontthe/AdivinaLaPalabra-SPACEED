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
        public string GenerateWord()
        {
            List<string> words = fileHandler.getWords();
            return words[random.Next(words.Count)];
        }

        public bool IsValidWord(string word)
        {
            List<string> words = fileHandler.getWords();
            return words.Contains(word);
        }


    }
}
