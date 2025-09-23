using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaLaPalabraRicardoHernandez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void layoutControl()
        {
            switch (Counter.TryNumber)
            {
                case 1:

                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            var valitador = new Validator();
            int result = valitador.Validate(1, "a");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            
            TextBox txt1 = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

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

            TextBox txt = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }
    }
}
