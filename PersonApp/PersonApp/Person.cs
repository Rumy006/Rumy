using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;



        public Person(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public Person()
        {
            
        }

        public Person(string firstName, string lastName)
        {
            this.firstName=firstName;
            this.lastName = lastName;

        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            //string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
}
