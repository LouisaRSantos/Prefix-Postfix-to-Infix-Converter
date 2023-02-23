using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prefix_and_Postfix_to_Infix_Converter
{
    public partial class PrePostConverter : Form
    {
        public static PrePostConverter instance;
        public PrePostConverter()
        {
            InitializeComponent();
            instance = this;
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the button you would like to use.\n" + "After clicking, a new window will open up.\n" + "Place the expression in the text box given,\n" + "then convert. Enjoy!");
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Infix is built with the help of the\n" + "collaborative minds of the creators:\n" +  "\n" + "Lambino, Carl Andrei\n" + "Margallo, Acel Gabrielle\n" + "Santos, Louisa Reighn\n" + "Trinidad, John Lawrence");
        }

        private void converterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Infix is a simple but terrible converter tool\n" + "that converts prefix or postfix expressions to infix notation!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_pre_Click(object sender, EventArgs e)
        {
            PrefixForm form2 = new PrefixForm();
            form2.Show();
        }

        private void BTN_post_Click(object sender, EventArgs e)
        {
            PostfixForm form3 = new PostfixForm();
            form3.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
