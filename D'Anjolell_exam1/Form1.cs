using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_exam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Code that closes the program
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell

            //Declare Constant
            const double increaseValue = .2;

            //Declare Variables
            int counterVariable;
            int monthlyInvestment;
            double productCost;
            double totalInvestment = double.Parse(txtCost.Text);
            string productName = txtName.Text;

            //If statement that determine if the right inputs were entered into the textboxes
            if (int.TryParse(txtMonths.Text, out monthlyInvestment) && double.TryParse(txtCost.Text, out productCost))
            {
                //Initalize counter variable to 1
                counterVariable = 1;

                //Clears the prior results from the listbox
                lstResults.Items.Clear();

                //Create while loop to run starting at 1 up to months entered
                while (counterVariable <= monthlyInvestment)
                {
                    //Calculate the increase of value in the investment
                    totalInvestment += productCost * increaseValue;

                    //Output results to listbox
                    lstResults.Items.Add(productName + ", Month " + counterVariable + ": $" + totalInvestment);

                    //Increments count variable to avoid infinite loop
                    counterVariable++;
                }

                //If else statements that determine if the investment was worthwhile
                if (totalInvestment > 3 * productCost)
                {
                    //Adds results to listbox
                    lstResults.Items.Add("Great investment");
                }

                else 
                {
                    //Adds results to listbox
                    lstResults.Items.Add("You chose poorly");
                }
            }
        }
    }
}
