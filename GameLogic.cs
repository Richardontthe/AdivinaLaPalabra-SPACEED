using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaLaPalabraRicardoHernandez
{
    internal class GameLogic
    {
        private Validator validator = new Validator();

        public void TextBoxValidate(TextBox textBox)
        {
            int position = Convert.ToInt32(textBox.Name.Substring(textBox.Name.Length - 1, 1));
            int validationResult = validator.Validate(position, textBox.Text.ToLower());

            if (validationResult == 1)
            {
                textBox.ForeColor = System.Drawing.Color.Green;
                textBox.BackColor = System.Drawing.Color.Gray;
            }
            else if (validationResult == 2)
            {
                textBox.ForeColor = System.Drawing.Color.Yellow;
                textBox.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                               textBox.ForeColor = System.Drawing.Color.Gray;
            }

        }

        public bool GameValidation(TextBox[] textBoxes)
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

        public String GetWordToGuess()
        {
            return validator.WordToGuess;
        }


    }
}
