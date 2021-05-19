using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private void PerformOperation()
        {
            switch (operation)
            {
                case " + ":
                    result += Double.Parse(lblResult.Text);
                    break;
                case "-":
                    result -= Double.Parse(lblResult.Text);
                    break;
                case " x ":
                    result *= Double.Parse(lblResult.Text);
                    break;
                case " ÷ ":
                    double temp = Double.Parse(lblResult.Text);
                    if (result == 0 && temp == 0)
                    {
                        lblResult.Text = "Undefinied";
                        return;
                    }
                    else if (temp == 0)
                    {
                        lblResult.Text = "Error";
                        return;
                    }
                    else
                    {
                        result /= temp;
                    }
                    break;
                default:
                    break;
            }
            lblResult.Text = result.ToString();
            lblOperation.Text = "";

        }         


        private bool isOperationAdded;
        private string operation;
        private double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button20_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if(lblResult.Text.Equals("0") || isOperationAdded)
            {
                lblResult.Text = "";
            }
            isOperationAdded = false;
            Button btn = (Button)sender;
            if (btn.Text.Equals("." , StringComparison.CurrentCultureIgnoreCase))
            {
                if(lblResult.Text.Contains("."))
                {
                    return;
                }
            }
            lblResult.Text += btn.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(result ==0 || isOperationAdded)
            {
                result = Double.Parse(lblResult.Text);
            }
            else
            {
                PerformOperation();
            }
            operation = btn.Text;
            isOperationAdded = true;
            lblOperation.Text = lblResult + " " + operation;

        }
    }
}
