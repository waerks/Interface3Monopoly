using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceMonopoly.Models
{
	public static class De
	{
		// Les variables membres
		public static int valeurMin = 1;
		public static int valeurMax = 6;
		public static Random rand = new Random();

		// Les méthodes publiques
		public static int[] Lancer(int nbDes)
		{
			// Stocker les résultats des dés
			int[] result = new int[nbDes];

			// Générer aléatoirement le résultat des deux dés
            for (int i = 0; i < nbDes; i++)
            {
				result[i] = rand.Next(valeurMin, valeurMax + 1);
            }

			return result;
        }
	}
}
