using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintJob_ctolodziecki3851
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //!!!!INSTRUCTIONS: for 115 sqft, 1 gal of paint, 8 hours @ 20.00 per hour display in winodows form
        private void calculatePaintJob_Click(object sender, EventArgs e)
        { 
            double squareFeet, gallons, laborRequired, laborCharges, paintPrice, totalCost;

            //get user input for sqft & paint price
            squareFeet = double.Parse(squareFeetTextBox.Text);
            paintPrice = double.Parse(paintPriceTextBox.Text);

            //calculate variables
            gallons = squareFeet / 115;
            laborRequired = (squareFeet * 8) / 115;
            laborCharges = laborRequired * 20.00;
            totalCost = laborCharges + paintPrice;

            /*Produces output to textbox's 
            "n2" in the string allows for decimal convertion to 2 places*/
            galsRequiredLabel.Text = gallons.ToString("n2");
            hoursRequiredLabel.Text = laborRequired.ToString("n2");
            costOfPaintLabel.Text = paintPrice.ToString("n2");
            laborChargesLabel.Text = laborCharges.ToString("n2");
            totalCostLabel.Text = totalCost.ToString("n2");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void galsRequiredLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
