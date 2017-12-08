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
        double leftOperand = 0;
        char @operator = ' ';
        bool isOperatorPressed = true;
        string expression = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            string sign = this.ActiveControl.Text;
            Button btn = sender as Button;
            switch (sign)
            {
                case "0":
                case "1":
                case "2": 
                case "3": 
                case "4": 
                case "5": 
                case "6": 
                case "7": 
                case "8": 
                case "9":
                    pressNumber(sign);
                    isOperatorPressed = false;
                    break;
                case "+":
                case "-":
                case "*":
                case "/": 
                case "=":
                    pressOperator(sign); break;
                case ",":
                    if (sign == "," && label1.Text.IndexOf(',') != -1) break;
                    if (label1.Text == "") label1.Text = "0,";
                    else pressNumber(sign); break;
                case "AC":
                    label1.Text = "";
                    isOperatorPressed = true;
                    leftOperand = 0;
                    @operator = ' ';
                    break;
                case "%":
                    if (label1.Text.ToString() != "")
                    {
                        if (leftOperand == 0) label1.Text = double.Parse(label1.Text) / 100 + "";
                        else label1.Text = leftOperand * double.Parse(label1.Text) / 100 + "";
                    };
                    break;
                case "+/-":
                    if(label1.Text.ToString() != "") label1.Text = (double.Parse(label1.Text) * (-1)) + ""; break;

            }
        }

        private void pressOperator(string sign)
        {
            if (isOperatorPressed) {
                @operator = sign != "=" ? char.Parse(sign) : ' ';
                return;
            }
            if (leftOperand == 0) leftOperand = double.Parse(label1.Text);
            else
            {
                switch (@operator)
                {
                    case '+': leftOperand += double.Parse(label1.Text); break;
                    case '-': leftOperand -= double.Parse(label1.Text); break;
                    case '*': leftOperand *= double.Parse(label1.Text); break;
                    case '/': leftOperand /= double.Parse(label1.Text); break;
                    default: break;
                }
                label1.Text = leftOperand + "";
            }
            if (sign == "=")
            {
                @operator = ' ';
                leftOperand = 0;
            }
            else
            {
                @operator = char.Parse(sign);
                isOperatorPressed = true;
            }
            
        }

        private void pressNumber(String sign)
        {
            if (isOperatorPressed || label1.Text == "0" && sign != ",") label1.Text = "";
            if (label1.Text == "" && sign == "0") label1.Text = "0,";
            else label1.Text += sign;
        }
    }
}
