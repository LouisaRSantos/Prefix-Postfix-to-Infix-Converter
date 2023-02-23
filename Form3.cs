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

        public static String ConvertPostfixToInfix(String postfix)
        {
            try
            {
                Stack<string> stack = new Stack<string>();

                for (int i = 0; i < postfix.Length; i++)
                {
                    if (theOperand(postfix[i]))
                    {
                        stack.Push(postfix[i].ToString());
                    }
                    else
                    {
                        string operand1 = stack.Pop();
                        string operand2 = stack.Pop();
                        string temp = "(" + operand2 + postfix[i] + operand1 + ")";
                        stack.Push(temp);
                    }
                }
                return stack.Pop();
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
            RTB1_F3.Text = ConvertPostfixToInfix(exp);
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
