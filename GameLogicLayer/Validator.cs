using AdivinaLaPalabraRicardoHernandez.GameLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaLaPalabraRicardoHernandez
{
    internal class Validator
    {
        private String wordToGuess;
        WordGenerator wordGenerator = new WordGenerator();

        /// <summary>
        /// Initializes a new instance of the Validator class and generates a word to guess randomly.
        /// </summary>
        public Validator()
        {
            wordToGuess = wordGenerator.GenerateWord();
        }

        public String WordToGuess { get => wordToGuess; }



        /// <summary>
        /// This method validates the position and letter inputs 1 if the letter 
        /// is in the exact location of the word to guess or 2 if the letter is present in 
        /// word to guess.
        /// </summary>
        /// <param name="position">Position of the letter</param>
        /// <param name="letter"> content of the textbox</param>
        /// <returns> int 1 or 2 (-1 if there is an error) </returns>
        public int Validate(int position, String letter)
        {
            int result = -1;
            letter = letter.ToLower();
            var wordToGuessArray = wordToGuess.ToCharArray();
            for (int i = 0; i < wordToGuessArray.Length; i++)
            {
                if (wordToGuessArray[i] == letter[0] && i == position - 1)
                {
                    result = 1;
                    break;
                }

            }

            if (wordToGuess.Contains(letter) && result != 1)
            {
                result = 2;

            }


            return result;
        }

        /// <summary>
        /// Resets the word to guess to a new one 
        /// </summary>
        public void ResetWord()
        {
            this.wordToGuess = wordGenerator.GenerateWord();
        }

        /// <summary>
        /// Method to check if the game was won
        /// </summary>
        /// <param name="word"> word to evaluate </param>
        /// <returns> True if its a win</returns>
        public bool WinCheck(String word) {
            if (word.ToLower() == this.wordToGuess.Trim().ToLower())
            {
                return true;
            }

            return false;

        }
    }
}
