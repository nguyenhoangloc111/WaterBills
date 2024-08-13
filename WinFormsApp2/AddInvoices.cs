using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp2
{
    public partial class AddInvoices : UserControl
    {
        public Invoice InvoiceManager { get; set; }
        public AddInvoices()
        {
            InitializeComponent();
            customerTypeCombobox.SelectedItem = "Household customer";
            string currentMonth = DateTime.Now.Month.ToString();
            currentMonthCombobox.SelectedItem = currentMonth;
            numberOfPeopleInput.Text = "0";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string messages = "";
            bool isValid = true;
            if (lastMonthNumberInput.Text.All(char.IsDigit))
            {      
                isValid = false;
                messages += "Please enter last month number!\n";
            }
            if (customerCodeInput.Text == "")
            {
                isValid = false;
                messages += "Please enter customer code!\n";
            }
            if (thisMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "Please enter this month number!\n";
            }
            if (numberOfPeopleInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "Please enter number of people!\n";
            }
            if (customerCodeInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "Please enter customer code!\n";
            } 
            if (customerTypeCombobox.SelectedItem.ToString()== "Household customer")
            {
                if (numberOfPeopleInput.Text == "" || numberOfPeopleInput.Text.All(char.IsDigit))
                {
                    isValid = false;
                    messages += "Please enter valid number of people!\n";
                    
                }
            }
            int lastMonth = int.Parse(lastMonthNumberInput.Text);
            int thisMonth = int.Parse(thisMonthNumberInput.Text);
            if (lastMonth > thisMonth)
            {
                isValid = false;
                messages += "Please re-enter last month!\n";
            }
            









            string customerCode = customerCodeInput.Text;
            string customerName = customerNameInput.Text;
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            int numberOfPeople = Convert.ToInt32(numberOfPeopleInput.Text);
            int lastMonthNumber = Convert.ToInt32(lastMonthNumberInput.Text);
            int thisMonthNumber = Convert.ToInt32(thisMonthNumberInput.Text);
            int currentMonth = Convert.ToInt32(currentMonthCombobox.SelectedItem);


           
            int consumption = thisMonthNumber - lastMonthNumber;
            double price = 0;
            double envFee = 0;
            if (customerType == "Household customer")
            {
                decimal consumptionPerPeople = consumption / numberOfPeople;
                if (consumptionPerPeople <= 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }
                if (consumptionPerPeople > 10 && consumptionPerPeople <= 20)
                {
                    price = 7052;
                    envFee = 705.2;
                }
                if (consumptionPerPeople > 20 && consumptionPerPeople <= 30)
                {
                    price = 8699;
                    envFee = 869.9;
                }
                if (consumptionPerPeople > 30)
                {
                    price = 15929;
                    envFee = 1592.9;
                }
            }
            if  (customerType == "Administrative agency, public services")
            {
                price = 9955;
                envFee = 995.5;
            }
            if (customerType == "Production units")
            {
                price = 11615;
                envFee = 1161.5;
            }
            if (customerType == "Business services")
            {
                price = 22068;
                envFee = 2206.8;
            }

            double subTotal = price * consumption;
            double VATFee = (subTotal + envFee) * 0.1;
            double Total = subTotal + envFee + VATFee;
            

            consumptionLabel.Text = consumption.ToString();
            priceLabel.Text = price.ToString();
            subtotalLabel.Text = Math.Round(subTotal,2).ToString();
            envFeeLable.Text = envFee.ToString();
            VATLabel.Text = Math.Round(VATFee).ToString();
            totalLabel.Text = Math.Round(Total,2).ToString();

            InvoiceManager.AddInvoice(customerCode, customerName, customerType, numberOfPeople,
                lastMonthNumber, thisMonthNumber,  currentMonth, subTotal, envFee, VATFee, Total);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customerNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            if (customerType == "Household customer")
                numberOfPeopleInput.Enabled = true;
            else
                numberOfPeopleInput.Enabled = false;
        }
    }
}
