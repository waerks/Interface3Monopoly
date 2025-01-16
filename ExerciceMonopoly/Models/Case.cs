using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceMonopoly.Models
{
	public class Case
	{
		// Les variables privées
		private List<Joueur> _visiteurs;

		// Les propriétés publiques
		public Joueur[] Visiteurs
		{
			get { return _visiteurs.ToArray(); }
		}
		public string Nom {  get; private set; }

		// Les constructeurs
		public Case(string nom) 
		{
			Nom = nom;
			_visiteurs = new List<Joueur>();
		}

		// Les méthodes publiques
		public void AjouterVisiteur(Joueur visiteur)
		{
			// Permet de regrouper les visiteurs d'une même case
			if (visiteur is null) return;

			if (_visiteurs.Contains(visiteur)) return;

			_visiteurs.Add(visiteur);
		}
		public void RetirerVisiteur(Joueur visiteur)
		{
			// Permet de retirer un joueur de la liste des visiteurs de cette case
			if (visiteur is null) return;

			if (!_visiteurs.Contains(visiteur)) return;

			_visiteurs.Remove(visiteur);
		}
	}
}
