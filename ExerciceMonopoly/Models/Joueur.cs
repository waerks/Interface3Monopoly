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
		private int _position;
		public string Nom { get; set; }
		public Pions Pion { get; set; }
		public int Position
		{
			get { return _position; }
			private set { _position = value; }
		}

		// Les méthodes publiques
		public bool Avancer() 
		{
			// Définir le nombre de dés
			int[] result = De.Lancer(2);

			// Additionner les deux résultats des dés pour définir le nombre de cases à avancer
			Position += result[0] + result[1];

			// Indique si le joueur a obtenu un double
			return result[0] == result[1];
		}
	}
}
