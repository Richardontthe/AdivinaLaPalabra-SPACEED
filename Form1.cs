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
    }
}
