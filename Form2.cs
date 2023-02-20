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

        static bool isOperator(char x)
        {
            return x == '+' || x == '-' || x == '*' || x == '/' || x == '^';
        }
        public static string convert(string str)
        {
            try
            {
                Stack stack = new Stack();
                int l = str.Length;

                for (int i = l - 1; i >= 0; i--)
                {
                    char c = str[i];

                    if (isOperator(c))
                    {
                        string op1 = (string)stack.Pop();
                        string op2 = (string)stack.Pop();

                        string temp = "(" + op1 + " " + c + " " + op2 + ")";    //with ()
                        //string temp = op1 + " " + c + " " + op2;              //without ()
                        stack.Push(temp);
                    }
                    else
                    {
                        stack.Push(c + "");
                    }
                }
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
            RTB1_F2.Text = convert(exp);
        }
    }
}
