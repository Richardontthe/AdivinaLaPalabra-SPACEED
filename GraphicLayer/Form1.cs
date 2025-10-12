using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdivinaLaPalabraRicardoHernandez
{
    public partial class Form1 : Form
    {
        GameLogic gameLogic = new GameLogic();
        public Form1()
        {
            InitializeComponent();
            layoutControl();
            gameLogic.nextLevelWord(Counter.winNumber);
            System.Diagnostics.Debug.WriteLine(gameLogic.GetWordToGuess());

        }

        /// <summary>
        /// Method to reset all controls in the form to their initial state for a game restar.
        /// </summary>
        private void resetControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox txt)
                {
                    txt.Clear();
                    txt.Enabled = true;
                    txt.ReadOnly = false;
                    txt.ForeColor = Color.Black;
                    txt.BackColor = Color.White;
                }
            }
        }
        /// <summary>
        /// Method to layout the controls based on the current try number.
        /// </summary>
        private void layoutControl()
        {
            switch (Counter.TryNumber)
            {
                case 1:
                    txt11.Enabled = true;
                    txt12.Enabled = true;
                    txt13.Enabled = true;
                    txt14.Enabled = true;
                    txt15.Enabled = true;

                    txt21.Enabled = false;
                    txt22.Enabled = false;
                    txt23.Enabled = false;
                    txt24.Enabled = false;
                    txt25.Enabled = false;

                    txt31.Enabled = false;
                    txt32.Enabled = false;
                    txt33.Enabled = false;
                    txt34.Enabled = false;
                    txt35.Enabled = false;

                    txt41.Enabled = false;
                    txt42.Enabled = false;
                    txt43.Enabled = false;
                    txt44.Enabled = false;
                    txt45.Enabled = false;

                    txt51.Enabled = false;
                    txt52.Enabled = false;
                    txt53.Enabled = false;
                    txt54.Enabled = false;
                    txt55.Enabled = false;

                    txt61.Enabled = false;
                    txt62.Enabled = false;
                    txt63.Enabled = false;
                    txt64.Enabled = false;
                    txt65.Enabled = false;
                    break;

                case 2:
                    txt11.ReadOnly = true;
                    txt12.ReadOnly = true;
                    txt13.ReadOnly = true;
                    txt14.ReadOnly = true;
                    txt15.ReadOnly = true;

                    txt21.Enabled = true;
                    txt22.Enabled = true;
                    txt23.Enabled = true;
                    txt24.Enabled = true;
                    txt25.Enabled = true;

                    txt31.Enabled = false;
                    txt32.Enabled = false;
                    txt33.Enabled = false;
                    txt34.Enabled = false;
                    txt35.Enabled = false;

                    txt41.Enabled = false;
                    txt42.Enabled = false;
                    txt43.Enabled = false;
                    txt44.Enabled = false;
                    txt45.Enabled = false;

                    txt51.Enabled = false;
                    txt52.Enabled = false;
                    txt53.Enabled = false;
                    txt54.Enabled = false;
                    txt55.Enabled = false;

                    txt61.Enabled = false;
                    txt62.Enabled = false;
                    txt63.Enabled = false;
                    txt64.Enabled = false;
                    txt65.Enabled = false;
                    break;

                case 3:
                    txt11.ReadOnly = true;
                    txt12.ReadOnly = true;
                    txt13.ReadOnly = true;
                    txt14.ReadOnly = true;
                    txt15.ReadOnly = true;

                    txt21.ReadOnly = true;
                    txt22.ReadOnly = true;
                    txt23.ReadOnly = true;
                    txt24.ReadOnly = true;
                    txt25.ReadOnly = true;

                    txt31.Enabled = true;
                    txt32.Enabled = true;
                    txt33.Enabled = true;
                    txt34.Enabled = true;
                    txt35.Enabled = true;

                    txt41.Enabled = false;
                    txt42.Enabled = false;
                    txt43.Enabled = false;
                    txt44.Enabled = false;
                    txt45.Enabled = false;

                    txt51.Enabled = false;
                    txt52.Enabled = false;
                    txt53.Enabled = false;
                    txt54.Enabled = false;
                    txt55.Enabled = false;

                    txt61.Enabled = false;
                    txt62.Enabled = false;
                    txt63.Enabled = false;
                    txt64.Enabled = false;
                    txt65.Enabled = false;
                    break;

                case 4:
                    txt11.ReadOnly = true;
                    txt12.ReadOnly = true;
                    txt13.ReadOnly = true;
                    txt14.ReadOnly = true;
                    txt15.ReadOnly = true;

                    txt21.ReadOnly = true;
                    txt22.ReadOnly = true;
                    txt23.ReadOnly = true;
                    txt24.ReadOnly = true;
                    txt25.ReadOnly = true;

                    txt31.ReadOnly = true;
                    txt32.ReadOnly = true;
                    txt33.ReadOnly = true;
                    txt34.ReadOnly = true;
                    txt35.ReadOnly = true;

                    txt41.Enabled = true;
                    txt42.Enabled = true;
                    txt43.Enabled = true;
                    txt44.Enabled = true;
                    txt45.Enabled = true;

                    txt51.Enabled = false;
                    txt52.Enabled = false;
                    txt53.Enabled = false;
                    txt54.Enabled = false;
                    txt55.Enabled = false;

                    txt61.Enabled = false;
                    txt62.Enabled = false;
                    txt63.Enabled = false;
                    txt64.Enabled = false;
                    txt65.Enabled = false;
                    break;

                case 5:
                    txt11.ReadOnly = true;
                    txt12.ReadOnly = true;
                    txt13.ReadOnly = true;
                    txt14.ReadOnly = true;
                    txt15.ReadOnly = true;

                    txt21.ReadOnly = true;
                    txt22.ReadOnly = true;
                    txt23.ReadOnly = true;
                    txt24.ReadOnly = true;
                    txt25.ReadOnly = true;

                    txt31.ReadOnly = true;
                    txt32.ReadOnly = true;
                    txt33.ReadOnly = true;
                    txt34.ReadOnly = true;
                    txt35.ReadOnly = true;

                    txt41.ReadOnly = true;
                    txt42.ReadOnly = true;
                    txt43.ReadOnly = true;
                    txt44.ReadOnly = true;
                    txt45.ReadOnly = true;

                    txt51.Enabled = true;
                    txt52.Enabled = true;
                    txt53.Enabled = true;
                    txt54.Enabled = true;
                    txt55.Enabled = true;

                    txt61.Enabled = false;
                    txt62.Enabled = false;
                    txt63.Enabled = false;
                    txt64.Enabled = false;
                    txt65.Enabled = false;
                    break;

                case 6:
                    txt11.ReadOnly = true;
                    txt12.ReadOnly = true;
                    txt13.ReadOnly = true;
                    txt14.ReadOnly = true;
                    txt15.ReadOnly = true;

                    txt21.ReadOnly = true;
                    txt22.ReadOnly = true;
                    txt23.ReadOnly = true;
                    txt24.ReadOnly = true;
                    txt25.ReadOnly = true;

                    txt31.ReadOnly = true;
                    txt32.ReadOnly = true;
                    txt33.ReadOnly = true;
                    txt34.ReadOnly = true;
                    txt35.ReadOnly = true;

                    txt41.ReadOnly = true;
                    txt42.ReadOnly = true;
                    txt43.ReadOnly = true;
                    txt44.ReadOnly = true;
                    txt45.ReadOnly = true;

                    txt51.ReadOnly = true;
                    txt52.ReadOnly = true;
                    txt53.ReadOnly = true;
                    txt54.ReadOnly = true;
                    txt55.ReadOnly = true;

                    txt61.Enabled = true;
                    txt62.Enabled = true;
                    txt63.Enabled = true;
                    txt64.Enabled = true;
                    txt65.Enabled = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Validate button click event. Validates the current row of text boxes and provides feedback to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox[] txtGroup = null;
            switch (Counter.TryNumber)
            {
                case 1:
                    txtGroup = new System.Windows.Forms.TextBox[] { txt11, txt12, txt13, txt14, txt15 };

                    break;
                case 2:
                    txtGroup = new System.Windows.Forms.TextBox[] { txt21, txt22, txt23, txt24, txt25 };
                    break;
                case 3:
                    txtGroup = new System.Windows.Forms.TextBox[] { txt31, txt32, txt33, txt34, txt35 };
                    break;
                case 4:
                    txtGroup = new System.Windows.Forms.TextBox[] { txt41, txt42, txt43, txt44, txt45 };
                    break;
                case 5:
                    txtGroup = new System.Windows.Forms.TextBox[] { txt51, txt52, txt53, txt54, txt55 };
                    break;
                case 6:
                    txtGroup = new System.Windows.Forms.TextBox[] { txt61, txt62, txt63, txt64, txt65 };
                    break;
            }



            if (!gameLogic.CheckEmptyTextBoxes(txtGroup))
            {

                if (!gameLogic.isValidWord(txtGroup) && !rdbTurbo.Checked)
                {

                    MessageBox.Show("Debe ser una palabra en español");
                    foreach (System.Windows.Forms.TextBox txt in txtGroup)
                    {
                        txt.Clear();
                    }
                    return;

                }

                if (gameLogic.GameValidation(txtGroup))
                {
                    MessageBox.Show("Felicidades! " +
                        "\nCada vez más cerca de resolver el acertijo...");
                    Counter.AddWin();
                    gameLogic.nextLevelWord(Counter.winNumber);
                    this.resetControls();
                }
                else
                {
                    Counter.AddTry();
                    if (Counter.TryNumber > 6)
                    {
                        MessageBox.Show("We are sorry, the word was: " + gameLogic.GetWordToGuess());
                        btnValidate.Enabled = false;
                    }
                    this.layoutControl();

                }
            }

            else
            {
                MessageBox.Show("No pueden quedar espacios vacíos");
            }




        }

        private void rdbTurbo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt41_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt42_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt43_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt44_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt45_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt51_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt52_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt53_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt54_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt55_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt61_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt62_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt63_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt64_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void txt65_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }
    }//no borrar
}// no borrar 




