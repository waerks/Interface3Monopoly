using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceMonopoly.Models
{
	public static class De
	{
		// Les variables privées
		private static int _valeurMin = 1;
		private static int _valeurMax = 6;
		private static Random _rand = new Random();

		// Les propriétés publiques
		public static int ValeurMin
		{
			get { return _valeurMin; }

			set 
			{
				// Doit être supérieur à 0
				if(value <= 0) return;

				_valeurMin = value;

				// La value est supérieure ou égale à valeurMax, alors + 1
				if (value >= _valeurMax) _valeurMax = value + 1;
			}
		}

		public static int ValeurMax
		{
			get { return _valeurMax; }

			set
			{
				// Doit être supérieur à 1
				if (value <= 1) return;

				_valeurMin = value;

				// La value est supérieure ou égale à valeurMax, alors - 1
				if (value <= _valeurMin) _valeurMin = value - 1;
			}
		}

		// Les méthodes publiques
		public static int[] Lancer(int nbDes)
		{
			// Stocker les résultats des dés
			int[] result = new int[nbDes];

			// Générer aléatoirement le résultat des deux dés
            for (int i = 0; i < nbDes; i++)
            {
				result[i] = _rand.Next(_valeurMin, _valeurMax + 1);
            }

			return result;
        }
	}
}
