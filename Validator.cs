using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaLaPalabraRicardoHernandez
{
    internal class Validator
    {
        private String wordToGuess; 

        public String WordToGuess { get => wordToGuess; }


        /// <summary>
        /// This method validates the position and letter inputs 1 if the letter 
        /// is in the exact location of the word to guess or 2 if the letter is present in 
        /// word to guess.
        /// </summary>
        /// <param name="position">Position of the letter</param>
        /// <param name="letter"> content of the textbox</param>
        /// <returns> int 1 or 2 </returns>
        public static int Validate(int position, String letter)
        {
            int result = -1;







            return result;
        }
    }
}
