using System;
namespace Examen
{
    public class Die
    {
        public readonly int nbFaces; // Constante
        private int visibleFace;
        private static Random generator = new Random();

        public int VisibleFace
        {
            get { return visibleFace; }
        }

        public Die() : this(6) { } // Appel de l’ autre constructeur

        public Die(int faces)
        {
            nbFaces = faces;
            Roll();
        }

        public void Roll()
        {
            visibleFace = generator.Next(nbFaces) + 1;
        }
    }
}
