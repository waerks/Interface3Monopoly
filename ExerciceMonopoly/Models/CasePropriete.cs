using ExerciceMonopoly.Models;
using ExerciceMonopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExerciceMonopoly.Models
{
	public class CasePropriete : Case
	{
		// Les propriétés publiques
		public string Nom { get; }
		public Couleurs Couleur { get; }
		public int Prix { get; }
		public bool EstHypotequee { get; }
		public Joueur Proprietaire { get; private set; }

		// Les constructeurs
		public CasePropriete(string nom, Couleurs couleur, int prix) : base(nom)
		{
			Nom = nom;
			Couleur = couleur;
			Prix = prix;
			EstHypotequee = false;
			Proprietaire = null;
		}

		// Les méthodes publiques
		public void Acheter(Joueur acheteur)
		{
			// Permet au Joueur d'acheter seulement si il a un solde suffisant et si la propriété n'est pas déjà achetée
			if (acheteur == null || Proprietaire != null) return;

			if (acheteur.Solde < Prix) return;

			// Si oui, le Joueur devient Propriétaire
			acheteur.Payer(Prix);
			Proprietaire = acheteur;
			acheteur.AjoutPropriete(this);
		}
	}
}