using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace aShopImSure
{
    public partial class Form1 : Form
    {
        double gooNum;
        double eggsNum;
        double meatNum;
        double gooCost = 1;
        double eggsCost = 2;
        double meatCost = 3;
        double taxRate = 0.13;
        double subtotal;
        double taxAmount;
        double totalAmount;
        double change;
        double tendered;
        double gooTotal;
        double eggsTotal;
        double meatTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reciptButton.Enabled = false;
            changeButton.Enabled = false;
            newOrderButton.Enabled = false;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            subTotalOutput.Text = " ";
            taxOutput.Text = " ";
            totalOutput.Text = " ";
            try
            {
                gooNum = Convert.ToDouble(gooInput.Text);
                eggsNum = Convert.ToDouble(eggsInput.Text);
                meatNum = Convert.ToDouble(meatInput.Text);

                gooTotal = (gooNum * gooCost);
                eggsTotal = (eggsNum * eggsCost);
                meatTotal = (meatNum * meatCost);

                subtotal = (gooTotal + eggsTotal + meatTotal);
                taxAmount = (subtotal * taxRate);
                totalAmount = (taxAmount + subtotal);

                subTotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalAmount.ToString("$##.##")}";

                changeButton.Enabled = true;
            }
            catch
            {
                reciptLabel.Text = "input error";

                changeButton.Enabled = false;
                reciptButton.Enabled = false;
                newOrderButton.Enabled = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);                
                

                change = (tendered - totalAmount);

                changeOutput.Text = $"{change.ToString("C")}";

                reciptButton.Enabled = true;
            }
            catch 
            {
                reciptLabel.ForeColor = Color.Black;

                reciptLabel.Text = "input error";
            }
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            try
            {                
                reciptLabel.ForeColor = Color.Black;

                reciptLabel.Text = $"\n         This Is Totally a Shop";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n\n Order # Something";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n This is A Date";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n\n Meat x{meatNum}... {meatTotal.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n Eggs x{eggsNum}... {eggsTotal.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n Goo x{gooNum}... {gooTotal.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n\n SubTotal... {subtotal.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n Tax... {taxAmount.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n Total... {totalAmount.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n\n Tendered... {tendered.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n Change... {change.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                reciptLabel.Text += $"\n\n      Thank You For Your Money";

                newOrderButton.Enabled = true;
            }
            catch 
            {
                reciptLabel.Text = "not Working";
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            reciptLabel.Text = " ";
            subTotalOutput.Text = " ";
            totalOutput.Text = " ";
            taxOutput.Text = " ";
            tenderedInput.Text = "";
            meatInput.Text = "";
            gooInput.Text = "";
            eggsInput.Text = "";
            changeOutput.Text = " ";

            newOrderButton.Enabled = false;
            reciptButton.Enabled = false;
            changeButton.Enabled = false;
        }
    }
}
