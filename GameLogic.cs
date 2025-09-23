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
                textBox.BackColor = System.Drawing.Color.Gray;
                textBox.ForeColor = System.Drawing.Color.Green;
            }
            else if (validationResult == 2)
            {
                textBox.BackColor = System.Drawing.Color.Gray;
                textBox.ForeColor = System.Drawing.Color.Yellow;
            }

        }



    }
}
