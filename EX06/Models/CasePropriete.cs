﻿using EX06.Enums;
using EX06.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06.Models
{
	public class CasePropriete : Case, IProprietaire
	{
		/* Version complète (seulement si vérification en entrée et sortie)
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }*/
		/*Auto-proprétée (Seulement si aucune vérification)*/
		public Couleurs Couleur { get; }
		public int Prix { get; }
		public bool EstHypotequee { get; private set; }
		public Joueur Proprietaire { get; private set; }

		public CasePropriete(string nom, Couleurs couleur, int prix) : base(nom)
		{
			Couleur = couleur;
			Prix = prix;
			/* Pas nécessaire de les affecter, les variables auront les bonnes valeurs car valeur par défaut de leur type
            
            EstHypotequee = false;
            Proprietaire = null;
            */
		}

		private void Acheter(Joueur acheteur)
		{
			if (acheteur is null) return;           //Gérer avec une Exception
			if (Proprietaire == acheteur) return;   //Gérer avec une Exception
			if (acheteur.Solde < Prix) return;      //Gérer avec une Exception
			acheteur.Payer(Prix);
			Proprietaire = acheteur;
			acheteur.AjouterPropriete(this);
		}

		private void Sejourner(Joueur visiteur)
		{
			if (visiteur is null) return;          //Gérer avec une Exception
			if (Proprietaire is null) return;      //Gérer avec une Exception
			if (Proprietaire == visiteur) return;  //Gérer avec une Exception
			int montant = Prix / 4;
			visiteur.Payer(montant);
			Proprietaire.EtrePaye(montant);
		}

		public override void Activer(Joueur visiteur)
		{
			if (visiteur is null) return;          //Gérer avec une Exception
			if (Proprietaire is null) Acheter(visiteur);
			else if (Proprietaire != visiteur) Sejourner(visiteur);
		}

		public void Hypothequer()
		{
			if (EstHypotequee) return;             //Gérer avec une Exception      
			EstHypotequee = true;
			Proprietaire.EtrePaye(Prix / 2);
		}

		public void Deshypothequer()
		{
			if (!EstHypotequee) return;          //Gérer avec une Exception
			int currentSolde = Proprietaire.Solde;
			Proprietaire.Payer((int)(Prix * 0.6));
			if (currentSolde != Proprietaire.Solde)
			{
				EstHypotequee = false;
			}
		}
	}
}