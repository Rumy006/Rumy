using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigerratorApp
{
    class Refrigerator
    {
        public double MaximumWeight { get; set; }
        private double currentWeight=0;
        private double remainingWeight=0;

        //public double MaximumWeight
        //{
        //    get { return maximumWeight; }
        //    set { maximumWeight = value; }
        //}

        public void AddItems(int noOfItems, double unitWeight)
        {
            if ((noOfItems * unitWeight) <= remainingWeight)
            {
                currentWeight += (noOfItems * unitWeight);
                

            }
            else
            {

                //MessageBox.Show("System Overflown");
                throw new Exception("Overflow");
            }
        }

        public double CurrentWeight()
        {
           
            return currentWeight;
        }

        public double RemainingWeight()
        {
            remainingWeight = MaximumWeight - currentWeight;
            return remainingWeight;
        }
    }
}
