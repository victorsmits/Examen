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

        public override string ToString()
        {
            return String.Format("{0} {1} ({2}) ", this.firstname,
             this.lastname, this.phonenumber);
        }
    }
}
