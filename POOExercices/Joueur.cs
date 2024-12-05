using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
	public class Joueur
	{
		public string nom;
		public Pions pions;
		public int position;

		public bool Avancer() {

			// Appeler la méthode De.Lancer pour les deux dés
			int[] resultats = De.Lancer(2);

			// Affiche les deux dés
			int compteur = 0;

			Console.WriteLine("Votre lancé :");
			foreach (var resultat in resultats)
			{
				compteur++;
				Console.WriteLine($"Dé n°{compteur} = {resultat}");
			}

			// Ajoute la somme des dés à la position
			int pionAvance = resultats[0] + resultats[1];

			position += pionAvance;

			// Vérifie si c'est un double résultat
			bool doubleDe = false;

			if (resultats[0] == resultats[1])
            {
				doubleDe = true;
            }

            return doubleDe; 
		}
	}
}
