using System;
namespace Examen
{
	public interface Complex
	{
		// Partie réelle du complexe
		double Real();

		//Partie imaginaire du complexe
		double Imag();

		//Module du complexe
		double Abs();

		// Argument du complexe
		double Arg();

		// Affichage du complexe
		string ToString();
	}

}
