using System;
namespace Examen
{
    public class Citizen
    {
        public String name;
        public String Firstname;


        public Citizen(string name, string Firstname)
        {
            this.name = name;
            this.Firstname = Firstname;
        }

        public override string ToString()
        {
            return string.Format(" {0} ({1}) ", name, Firstname);
        }
    }
}
