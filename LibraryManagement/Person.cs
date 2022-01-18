using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
   public abstract class Person
    {
        protected Person(string firstName, string lastName, string emailAddress, string address, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string address { get; set; }
        public long phoneNumber { get; set; }
       



        

    }
}
