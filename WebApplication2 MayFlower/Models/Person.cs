using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2_MayFlower.Models
{
    public class Person
    {
        private string firstName = "n/a";
        private string lastName = "n/a";

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }


        public Person():this("n/a", "n/a")
        {
            // There could be a lot of code here
            // in our case there isn't but there could be
            // It is called the empty constructor because there are no parameters
            // NOT because there is no code
        }


        public Person( string aFirstName, string aLastName)
          
        {
            // There is no set for StudentId
            
            this.FirstName = aFirstName;
            this.LastName = aLastName;
           
        }


        public override string ToString()
        {
            string message = "";
           
            message = message + "FirstName: " + this.FirstName + "\n";
            message = message + "LastName: " + this.LastName + "\n";
           
            return message;
        }


    }
}
