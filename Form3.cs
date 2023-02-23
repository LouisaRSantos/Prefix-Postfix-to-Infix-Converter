using System;
using System.Collections;
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
    public partial class PostfixForm : Form
    {
        public static PostfixForm instance;
        public PostfixForm()
        {
            InitializeComponent();
            instance = this;
        }
        static Boolean theOperand(char x)
        {
            return (x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z');
            //return x == '+' || x == '-' || x == '*' || x == '/' || x == '^';
        }

        static String getInfix(String exp)
        {
            try
            {
                Stack s = new Stack();

                for (int i = 0; i < exp.Length; i++)
                {
                    if (theOperand(exp[i]))
                    {
                        s.Push(exp[i] + "");
                    }
                    else
                    {
                        String op1 = (String)s.Peek();
                        s.Pop();
                        String op2 = (String)s.Peek();
                        s.Pop();
                        s.Push("(" + op2 + " " + exp[i] + " " + op1 + ")");
                    }
                }
                return (String)s.Peek();
            }
            catch
            {
                MessageBox.Show("No Input");
                return null;
            }
        }

        private void btnconvert_F3_Click(object sender, EventArgs e)
        {
            string exp = T1_F3.Text;
            RTB1_F3.Text = getInfix(exp);
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type in the postfix expression you\n" + "like to convert, then press the\n" +
                "'convert' button.");
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Infix is built with the help of the\n" + "collaborative minds of the creators:\n" + "\n" +
                "Lambino, Carl Andrei\n" + "Margallo, Acel Gabrielle\n" + "Santos, Louisa Reighn\n" +
                "Trinidad, John Lawrence");
        }

        private void converterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Infix is a simple but terrible converter tool\n" +
                "that converts prefix or postfix expressions to infix notation!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
