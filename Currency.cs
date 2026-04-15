using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Currency_Conversion
{
    public partial class Currency : Form
    {
        public Currency()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FromComboBox.Items.Add("USD");
            FromComboBox.Items.Add("SAR");

            comboBox2.Items.Add("USD");
            comboBox2.Items.Add("SAR");

            FromComboBox.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;



            amountTextBox.KeyDown += AmountTextBox_KeyDown;
        }

        private void AmountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConvert.PerformClick();
            } }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (double.TryParse(amountTextBox.Text, out double amount))
            {
                string from = FromComboBox.Text;
                string to = comboBox2.Text;

                double rate = (from == "SAR" && to == "USD") ? 0.2667 :
                              (from == "USD" && to == "SAR") ? 3.75 : 1.0;

                double result = amount * rate;
                label2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("الرجاء إدخال مبلغ صحيح");
            }
        }

}
 }
