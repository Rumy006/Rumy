using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Account
    {
        private string number;
        private string name;
        private double balance =0;

        public Account(string number, string name):this()
        {
            this.number = number;

            this.name = name;
        }

        public Account()
        {

        }

        public string Number
        {
            get 
            { return number; }
            set
            {
                number = value;              
            }
        }

        public string Name
        {
            get 
            { return name; }

            set
            { name = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        //public void SetNumber(string newNumber)
        //{
        //    Number = newNumber;
        //}

        //public string GetNumber()
        //{
        //    return Number;
        //}



        public string Deposit(double amount)
        {
            balance = Balance + amount;
            return "Deposited";
        }

        public string Withdraw(double amount)
        {
            balance = Balance - amount;
            return "Withdrawn";
        }

    }
}
