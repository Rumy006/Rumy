using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class PersonNameUI : Form
    {
        private Person aPerson;
        public PersonNameUI()
        {
            InitializeComponent();
        }

        private void fullNameButton_Click(object sender, EventArgs e)
        {
            aPerson=new Person(firstNameTextBox.Text,middleNameTextBox.Text,lastNameTextBox.Text);
            Person Person2=new Person(firstNameTextBox.Text,lastNameTextBox.Text);
            Person Person3=new Person();
            //SetNames();
            MessageBox.Show(aPerson.GetFullName());

        }

        //private void SetNames()
        //{
        //    aPerson.firstName = firstNameTextBox.Text;
        //    aPerson.middleName = middleNameTextBox.Text;
        //    aPerson.lastName = lastNameTextBox.Text;
           
        //}

        private void reverseNameButton_Click(object sender, EventArgs e)
        {
            aPerson = new Person(firstNameTextBox.Text, middleNameTextBox.Text, lastNameTextBox.Text);
            //SetNames();
            MessageBox.Show(aPerson.GetReverseName());
        }
    }
}
