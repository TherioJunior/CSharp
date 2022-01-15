using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Calculator_csharp
{
    public partial class CalcDesign : Form
    {
        public CalcDesign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmCalculateButton_Click(object sender, EventArgs e)
        {
            string NumberOneInputString = NumberOneInput.Text;
            string NumberTwoInputString = NumberTwoInput.Text;

            // Error handling to prevent application errors.
            if (NumberOneInputString == "Number one" && NumberTwoInputString == "Number two")
            {
                this.ResultLabel.Text = "Error: You're missing both numbers.";
                return;
            }

            if (NumberOneInputString == "Number one")
            {
                this.ResultLabel.Text = "Error: You're missing number one.";
                return;
            }

            if (NumberTwoInputString == "Number two")
            {
                this.ResultLabel.Text = "Error: You're missing number two";
                return;
            }

            // Calculation variables
            int SelectedOption = MathOption.SelectedIndex;

            int NumberOne = Convert.ToInt32(NumberOneInputString);
            int NumberTwo = Convert.ToInt32(NumberTwoInputString);

            float Result = 0.0f;

            // Calculating
            switch (SelectedOption)
            {
                case 0:
                    Result = NumberOne + NumberTwo;
                    break;
                case 1:
                    Result = NumberOne - NumberTwo;
                    break;
                case 2:
                    Result = NumberOne * NumberTwo;
                    break;
                case 3:
                    Result = NumberOne / NumberTwo;
                    break;
            }

            // Outputting the result
            this.ResultLabel.Text = "Result: " + Result.ToString();
        }
    }
}
