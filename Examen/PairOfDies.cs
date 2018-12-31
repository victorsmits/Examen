using System;
namespace Examen
{
    public class PairOfDice
    {
        private int nbFaces;
        private Die die1, die2; // Composition à partir
                                // de deux objets Die
        public PairOfDice(int faces)
        {
            nbFaces = faces;
            die1 = new Die(faces);
            die2 = new Die(faces);
        }

        public void PrintFaces()
        {
            Console.WriteLine(String.Format("{0} , {1}", die1.
           VisibleFace, die2.VisibleFace));
        }
    }
}
