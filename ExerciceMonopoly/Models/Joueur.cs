using ExerciceMonopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceMonopoly.Models
{
	public class Joueur
	{
		// Les variables membres
		private int _position;
		private List<CasePropriete> _proprietes;

		// Les propriétés publiques
		public string Nom { get; set; }
		public Pions Pion { get; set; }
		public int Position
		{
			get { return _position; }
			private set { _position = value; }
		}
		public CasePropriete[] Proprietes
		{
			get { return _proprietes.ToArray(); }
		}
		public int Solde { get; private set; }

		public Joueur (string nom, Pions pion)
		{
			Nom = nom;
			Pion = pion;
			Solde = 1500;
			_proprietes = new List<CasePropriete>();
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

		public void EtrePaye(int montant)
		{
			// Ajout le montant au Solde du Joueur
			if (montant <= 0) return;
			Solde += montant;
		}

		public void Payer(int montant)
		{
			// Diminue le Solde du Joueur
			if (montant <= 0) return;
			// Empêche le Solde d'être en dessous de 0
			if (Solde < montant) return;
			Solde -= montant;
		}

		public void AjoutPropriete(CasePropriete propriete)
		{
			// Ajoute la propriété dans la liste des propriétés du joueur
			if (propriete == null) return;

			_proprietes.Add(propriete);
		}

		public static Joueur operator +(Joueur left, int right)
		{
			// Permet d'additionner le montant pour l'augmenter
			left.EtrePaye(right);
			return left;
		}

		public static CasePropriete[] operator +(Joueur left, CasePropriete right)
		{
			// Permet de diviser le montant pour le diminuer
			right.Acheter(left);
			return left.Proprietes;
		}
	}
}
