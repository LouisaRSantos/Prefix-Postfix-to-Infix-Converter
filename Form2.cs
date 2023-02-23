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
    public partial class PrefixForm : Form
    {
        public static PrefixForm instance;
        public PrefixForm()
        {
            InitializeComponent();
            instance = this;
        }
        //A static method that returns a Boolean value.
        static bool isOperator(char x)
        {
            return x == '+' || x == '-' || x == '*' || x == '/' || x == '^';
        }

        public static string ConvertPrefixToInfix(string prefix)
        {
            try
            {
                //created a stack
                Stack stack = new Stack();
                //int variable l
                int l = prefix.Length;

                for (int i = l - 1; i >= 0; i--)
                {
                    //define variable char
                    char c = prefix[i];

                    if (isOperator(c))
                    {
                        //operand is the variable like constant
                        string operand1 = (string)stack.Pop();
                        string operand2 = (string)stack.Pop();

                        string temp = "(" + operand1 + " " + c + " " + operand2 + ")";    //with ()
                        //string temp = op1 + " " + c + " " + op2;              //without ()
                        stack.Push(temp);
                    }
                    else
                    {
                        stack.Push(c + "");
                    }
                }
                //Once we have processed all the characters in the expression, the final 
                //infix expression is the top element of the stack, so we simply pop it and return it.
                return (string)stack.Pop();
            }
            catch
            {
                MessageBox.Show("Error");
                return null;
            }
        }
        private void btnconvert_Click(object sender, EventArgs e)
        {
            string exp = T1_F2.Text;
            RTB1_F2.Text = ConvertPrefixToInfix(exp);
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type in the prefix expression you\n" + "like to convert, then press the\n" + 
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
