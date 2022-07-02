using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp_Revent
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = "";
        bool enter_operator = false;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Clear the default value zero when a button is pressed
            if (display.Text == "0" || enter_operator)
                display.Clear();

            enter_operator = false;

            // Object
            Button b = (Button)sender;

            // Anytime the user press button dot(".") 
            if (b.Text == ".")
            {
            // Once a dot(".") is pressed, don't contain another (".") 
                if (!display.Text.Contains("."))
                {
                    display.Text = display.Text + b.Text;
                }

            }
            // If the dot button is not pressed,concatenate the pressed buttons
            else
            {
                display.Text = display.Text + b.Text;

            }

        }

        private void operator_Click(object sender, EventArgs e)
        {
            // Object
            Button b = (Button)sender;
            // Extract the operator in the button
            operation = b.Text;
            result = Double.Parse(display.Text);
            enter_operator = true;
            // Display the user input on the top label
            label_screen.Text = result + " " + operation;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the main screen and the top screen
            display.Text = "0";
            label_screen.Text = " ";
            // Assign result value to zero
            result = 0;
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            display.Text = " ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    display.Text = (result + Double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (result - Double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (result * Double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    if (display.Text == "0")
                    {
                        display.Text = "Infinity";
                    }
                    else
                    {
                        display.Text = (result * Double.Parse(display.Text)).ToString(); 
                    }
                    break;

                default:
                    display.Text = "Invalid operator";
                    break;





            }
        }
    }
}

