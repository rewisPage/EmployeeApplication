using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public class Employee
    {
        // Encapsulated private members
        private string id;
        private string firstName;
        private string lastName;
        private string position;

        // Public properties accessing the private members
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // Overloaded Constructor 1: Default
        public Employee()
        {
            this.id = "";
            this.firstName = "";
            this.lastName = "";
            this.position = "";
        }

        // Overloaded Constructor 2: Parameterized (utilizing the 'this' keyword)
        public Employee(string id, string firstName, string lastName, string position)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
    }
}
