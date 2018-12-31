using System;
namespace Examen
{
    class Contact
    {
        private string firstname, lastname;
        private int phonenumber;

        public Contact(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.phonenumber = 0;
        }

        public void SetPhoneNumber(int number)
        {
            this.phonenumber = number;
        }

        // [...]
    }
}
