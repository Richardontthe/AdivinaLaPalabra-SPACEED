using AdivinaLaPalabraRicardoHernandez.GameLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdivinaLaPalabraRicardoHernandez
{
    internal class GameLogic
    {
        private Validator validator = new Validator();

        /// <summary>
        /// validates the textBox input and changes its color according to the validation result
        /// </summary>
        /// <param name="textBox"></param>
        public void TextBoxValidate(System.Windows.Forms.TextBox textBox)
        {
            int position = Convert.ToInt32(textBox.Name.Substring(textBox.Name.Length - 1, 1));
            int validationResult = validator.Validate(position, textBox.Text.ToLower());

            if (validationResult == 1)
            {
                textBox.ForeColor = System.Drawing.Color.LightGreen;
                textBox.BackColor = System.Drawing.Color.Gray;
            }
            else if (validationResult == 2)
            {
                textBox.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                textBox.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                               textBox.ForeColor = System.Drawing.Color.Gray;
                               textBox.BackColor = System.Drawing.Color.OrangeRed;
            }

        }

        /// <summary>
        /// Validates the entire word and changes the color of the textBoxes accordingly
        /// </summary>
        /// <param name="textBoxes"></param>
        /// <returns>true if there is a win</returns>
        public bool GameValidation(System.Windows.Forms.TextBox[] textBoxes)
        {
            StringBuilder currentWord = new StringBuilder();
            foreach (var textBox in textBoxes)
            {
                currentWord.Append(textBox.Text);
            }
            if(validator.WinCheck(currentWord.ToString()))
            {
                foreach (var textBox in textBoxes)
                {
                    textBox.BackColor = System.Drawing.Color.Green;
                    textBox.ForeColor = System.Drawing.Color.White;
                }
                return true;
            }

            else
            {
                foreach (var textBox in textBoxes)
                {
                   TextBoxValidate(textBox);
                }
                return false;
            }


        }

        /// <summary>
        /// validates if the word formed by the textBoxes is a valid word
        /// </summary>
        /// <param name="textBoxes"></param>
        /// <returns></returns>

        public bool isValidWord(System.Windows.Forms.TextBox[]  textBoxes)
        {
            StringBuilder currentWord = new StringBuilder();
            foreach (var textBox in textBoxes)
            {
                currentWord.Append(textBox.Text);
            }
            WordGenerator wordGenerator = new WordGenerator();
            return new WordGenerator().IsValidWord(currentWord.ToString());
        }

        /// <summary>
        /// Returns the word to guess
        /// </summary>
        /// <returns></returns>
        public String GetWordToGuess()
        {
            return validator.WordToGuess;
        }


        /// <summary>
        /// Chechks if any of the textBoxes are empty
        /// </summary>
        /// <param name="textBoxes"></param>
        /// <returns></returns>
        public bool CheckEmptyTextBoxes(System.Windows.Forms.TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (String.IsNullOrEmpty(textBox.Text))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Resets the game by resetting the word and the try counter
        /// </summary>
        public void ResetGame()
        {
            validator.ResetWord();
            Counter.ResetCounter();
        }

    }
}
