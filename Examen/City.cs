using System;
namespace Examen
{
    public class City
    {
        private Citizen mayor; // Bourgmestre de la ville
        private String name; // Nom de la ville

        public City(String s)
        {
            name = s;
        }

        public void ChangeMayor(Citizen c)
        {
            mayor = c;
        }
    }
}
