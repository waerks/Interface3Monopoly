using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
	public static class De
	{
		public static int valeurMin;
		public static int valeurMax;
		public static Random rnd;

		public static int[] Lancer(int nbDes)
		{
			// Atribuer les valeurs (max 6 -> 6 faces)
			valeurMin = 1;
			valeurMax = 6;

			// rnd est null de base donc définir un new rnd
			if (rnd is null)
			{
				rnd = new Random();
			}

			// Mettre les 2 dés rnd dans l'array resultat
			int[] resultats = new int[nbDes];

            for (int i = 0; i < nbDes; i++)
            {
				resultats[i] = rnd.Next(valeurMin, valeurMax+1);
            }

			// Renvoyer le resultat^parce que la méthode l'oblige
            return resultats;
		}
	}
}
