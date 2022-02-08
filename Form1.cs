using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //do some work
            parseBracketString it = new parseBracketString();

            bool a = it.parseTheString("(");
            bool a1 = it.parseTheString("()[");
            bool a2 = it.parseTheString("()");
            bool b = it.parseTheString("()[]{}");
            bool c = it.parseTheString("(]");
            bool d = it.parseTheString("([)]");
            bool e5 = it.parseTheString("{[]}");
            bool f = it.parseTheString("{[()]}");
            bool f2 = it.parseTheString("{[[{]]]}");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MinStack minStack = new MinStack();
            minStack.push(-2);
            minStack.push(0);
            minStack.push(-3);
            minStack.getMin(); // return -3
            minStack.pop();
            minStack.top();    // return 0
            minStack.getMin(); // return -2

            minStack.push(-2147483648);
            minStack.push(21474836471);
        }
    }
}
