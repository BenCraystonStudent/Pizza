using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "The extras that you have chosen are: ";

            

            if (chkMush.Checked)

                message += " mushrooms ";

            if (chkJal.Checked)

                message += " jalapenos ";

            if (chkPep.Checked)

                message += " peppers ";

            string messageBase;

            if (radPan.Checked)

                messageBase = "You have chosen Deep Pan ";

            else if (radThin.Checked)

                messageBase = "You have chosen Thin & Crispy ";

            else

                messageBase = "You have chosen the standard base ";

            string messageSize = "The size is: ";

            if (radSmall.Checked)

                messageSize = "You have chosen size small ";

            if (radMed.Checked)

                messageSize = "You have chosen size medium ";

            if (radLarge.Checked)

                messageSize = "You have chosen size large ";

            MessageBox.Show(message);
            MessageBox.Show(messageBase);
            MessageBox.Show(messageSize);
        }
    }
}
