using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigerratorApp
{
    public partial class RefrigeratorUI : Form
    {

        private Refrigerator aRefrigerator;
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator = new Refrigerator();
            aRefrigerator. MaximumWeight = Convert.ToDouble(maxWeightTextBox.Text);
            currentWeightTextBox.Text = Convert.ToString(aRefrigerator.CurrentWeight());
            remainingWeightTextBox.Text = Convert.ToString(aRefrigerator.RemainingWeight());
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (aRefrigerator != null)
            {
                int noOfItems = Convert.ToInt16(noOfItemsTextBox.Text);
                double unitWeight = Convert.ToDouble(weightUnitTextBox.Text);

                try
                {
                    aRefrigerator.AddItems(noOfItems, unitWeight);
                    currentWeightTextBox.Text = Convert.ToString(aRefrigerator.CurrentWeight());
                    remainingWeightTextBox.Text = Convert.ToString(aRefrigerator.RemainingWeight());
                }
                catch (Exception Obj)
                {

                    MessageBox.Show(Obj.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter capacity ftrst");
            }
        }
    }
}
