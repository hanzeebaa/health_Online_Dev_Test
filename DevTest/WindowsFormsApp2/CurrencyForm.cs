using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CurrencyForm :  Form, ICurrencyForm
    {
        private CurrencyConverterController currencyController;
        public CurrencyForm()
        {
            InitializeComponent();
            //Load += Form1_Load;

        }

        public ListView CurrencyListView
        {
            get
            {
                return listView1;
            }
        }

        public ComboBox ComboBoxFrom
        {
            get
            {
                return currencyFrom;
            }
        }

        public ComboBox ComboBoxTo
        {
            get
            {
                return currencyTo;
            }
        }

        public void ConversionValue(string Value)
        {
            conversionValue.Text = Value;
        }
        
        public void SetController(CurrencyConverterController controller)
        {
            currencyController = controller;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            currencyController.EnteredValue(textBox1.Text);
        }

        private void radioButtonProvider1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                currencyController.Provider1Selected = rb.Checked;
            }
        }

        private void currencyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb !=null)
            {
                currencyController.ConvertCurrencyFromValue = (string)cb.SelectedItem;
            }
        }

        private void currencyTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb != null)
            {
                currencyController.CurrencyToValue = (string)cb.SelectedItem;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currencyController.DoConversion();
        }
    }
}
