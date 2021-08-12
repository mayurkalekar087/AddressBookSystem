using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class Contact
    {
        public Contact(string firstname, string lastname, string address, string city, string state, string zipcode, string phonenumber, string email)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipcode;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
