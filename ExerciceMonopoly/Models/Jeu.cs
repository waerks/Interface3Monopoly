using ExerciceMonopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceMonopoly.Models
{
	public class Jeu
	{
		// Les variables privées
		private List<Joueur> _joueurs;
		private List<CasePropriete> _plateau;

		// Les propriétés publiques
		public Joueur[] Joueurs { get { return _joueurs.ToArray(); } }
		public CasePropriete[] Plateau { get { return _plateau.ToArray(); } }

		// Les indexeurs
		public CasePropriete this[int numero]
		{
			get
			{
				numero = numero % _plateau.Count;
				return _plateau[numero];
			}
		}

		public Joueur this[Pions pion]
		{
			get
			{
                foreach (Joueur j in _joueurs)
                {
                    if (j.Pion == pion) return j;
                }

				return null;
            }
		}

		// Les constructeurs
		public Jeu(CasePropriete[] cases)
		{
			// Obtient un tableau de cases et initialise les Jouers en liste vide
			if (cases is null) return;

			if (cases.Length <= 0) return;

			_joueurs = new List<Joueur>();
			_plateau = new List<CasePropriete>(cases);
		}

		// Les méthodes publiques
		public void AjouterJoueur (string nom, Pions pion)
		{
			// Vérifie avant l'ajout si le pion est libre
			if (nom is null) return;

			if (this[pion] is not null) return;

			_joueurs.Add(new Joueur(nom, pion));
		}
	}
}
