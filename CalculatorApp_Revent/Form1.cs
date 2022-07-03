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
        // Declare all variables 
        Double result = 0;
        string operation = "";
        bool enter_operator = false;
        char op;
        string firstNum, secondNum;
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
//=================================================================================================

// Number button click section start
        private void btn_Click(object sender, EventArgs e)
        {
            // Clear the default value zero when a button is pressed
            if (display.Text == "0" || enter_operator)
                display.Clear();
            // no operator is clicked
            enter_operator = false;

            // Object
            Button b = (Button)sender;

            // if the user press button dot(".") 
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

    // Number button click section end
//================================================================================================

    // Operators section start
        private void operator_Click(object sender, EventArgs e)
        {
            // Object
            Button b = (Button)sender;

            if(result != 0)
            {
                Equal_btn.PerformClick();
                // Extract the operator in the button
                operation = b.Text;
               
                enter_operator = true;
                // Display the user input on the top label
                label_screen.Text = result + " " + operation;

            }
            else
            {
                // Extract the operator in the button
                operation = b.Text;
                result = Double.Parse(display.Text);
                enter_operator = true;
                // Display the user input on the top label
                label_screen.Text = result + " " + operation;

            }
          
        }

    // Operators section ends
//=======================================================================================

    // Button clear section start

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the main screen and the top screen
            display.Text = "0";
            label_screen.Text = " ";
            // Assign result value to zero
            result = 0;
            
        }
    // Button clear section end
//==========================================================================================
    

        private void button22_Click(object sender, EventArgs e)
        {
            display.Text = " ";
        }
//==========================================================================================
    // Equal button section start
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
                        display.Text = (result / Double.Parse(display.Text)).ToString(); 
                    }
                    break;

                default:
                    display.Text = "Invalid operator";
                    break;

            }
            result = Double.Parse(display.Text);
            label_screen.Text = "";
           
            

        }

        // Equal button section Ends
//==========================================================================================
        // Backspace button 
        private void backSpace_Click(object sender, EventArgs e)
        {
           
            if(display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
            if (display.Text == "")
            {
                display.Text = "0";
            }

        }

       
//==========================================================================================
        private void plusMinus_Click(object sender, EventArgs e)
        {
            // Convert the value in display.Text to double 
            double plusMinus = Convert.ToDouble(display.Text);
            // Multiply the value in display.Text by -1
            display.Text = Convert.ToString(-1 * plusMinus);
        }
//==========================================================================================
        private void squareRoot_Click(object sender, EventArgs e)
        {
            display.Text = Math.Sqrt(Double.Parse(display.Text)).ToString();
        }
//==========================================================================================

    }
}

