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

        }

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
                    txt11.ReadOnly = false;
                    txt12.ReadOnly = false;
                    txt13.ReadOnly = false;
                    txt14.ReadOnly = false;
                    txt15.ReadOnly = false;

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
                    txt11.Enabled = false;
                    txt12.Enabled = false;
                    txt13.Enabled = false;
                    txt14.Enabled = false;
                    txt15.Enabled = false;

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
                    txt11.Enabled = false;
                    txt12.Enabled = false;
                    txt13.Enabled = false;
                    txt14.Enabled = false;
                    txt15.Enabled = false;

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
                    txt11.Enabled = false;
                    txt12.Enabled = false;
                    txt13.Enabled = false;
                    txt14.Enabled = false;
                    txt15.Enabled = false;

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

                if (gameLogic.GameValidation(txtGroup))
                {
                    MessageBox.Show("We have a winner!");
                }
                else
                {
                    Counter.AddTry();
                    if (Counter.TryNumber > 6)
                    {
                        MessageBox.Show("We are sorry, the word was: " + gameLogic.GetWordToGuess());
                    }
                    layoutControl();
                }
            }
            else
            {
                MessageBox.Show("Please complete all words before validating");

            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt1 = sender as System.Windows.Forms.TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
