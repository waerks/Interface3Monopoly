using ExerciceMonopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceMonopoly.Models
{
	internal class Joueur
	{
		// Les variables membres
		public string nom;
		public Pions pion;
		public int position;

		// Les méthodes publiques
		public bool Avancer() 
		{
			// Définir le nombre de dés
			int[] result = De.Lancer(2);

			// Additionner les deux résultats des dés pour définir le nombre de cases à avancer
			position += result[0] + result[1];

			// Indique si le joueur a obtenu un double
			return result[0] == result[1];
		}
	}
}
