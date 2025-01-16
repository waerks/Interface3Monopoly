using ExerciceMonopoly.Enums;
using ExerciceMonopoly.Models;

namespace ExerciceMonopoly
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Configurer l'encodage UTF-8 pour la console
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			/* Exercice n°1 à n°3
			 * 
			// Définir un joueur
			Joueur joueur1 = new Joueur("Anaïs", Pions.Voiture);

			// Position du Joueur
			Console.WriteLine("----- 📍 -----");
			Console.WriteLine($"Bougez {joueur1.Pion.GetEmoji()} de la case {joueur1.Position}.");

			// Si le Joueur a fait un double
			if( joueur1.Avancer())
			{
				Console.WriteLine($"Bravo {joueur1.Nom}! Vous avez fait un double!");
			}

			Console.WriteLine($"{joueur1.Pion.GetEmoji()} est sur la case {joueur1.Position}.");

			// Donner le Solde du Joueur
			Console.WriteLine();
			Console.WriteLine("----- 💰 -----");
			Console.WriteLine($"Votre solde est de {joueur1.Solde} 💲Monopoly.");

			// Les propriétés du Joueur
			Console.WriteLine();
			Console.WriteLine("----- 🏘️ -----");
			Console.WriteLine("Vos propriétés :");
			foreach (CasePropriete prop in joueur1.Proprietes)
			{
				Console.WriteLine($"\t- {prop.Nom} ({prop.Couleur})");
			}

			// Définir une case et la tester
			Console.WriteLine();
			Console.WriteLine("----- ℹ️ -----");
			CasePropriete i3Patio = new CasePropriete("Patio Interface 3", Couleurs.Marron, 20);

			Console.WriteLine($"La première case du jeu Monopoly est :");
			Console.WriteLine($"📫 {i3Patio.Nom}");
			Console.WriteLine($"--- Couleur : {i3Patio.Couleur.GetEmoji()}");
			Console.WriteLine($"--- Prix : {i3Patio.Prix} 💲Monopoly");

			// Est-ce que le terrain est hypothéqué
			if (i3Patio.EstHypotequee) Console.WriteLine("----- Ce terrain est hypotèqué...");
			else Console.WriteLine("----- Ce terrain n'est pas hypotèqué.");

			// Est-ce que le terrain est vendu
			if (i3Patio.Proprietaire is null) Console.WriteLine("----- Ce terrain est en vente!");
			else Console.WriteLine($"----- Ce terrain appartient à {i3Patio.Proprietaire.Nom}");

			// Le joueur achète la case
			i3Patio.Acheter(joueur1);

			// Informations sur le Solde et Propriétés
			Console.WriteLine();
			Console.WriteLine("----- 💰 -----");
			Console.WriteLine($"Votre solde est de {joueur1.Solde} $Monopoly.");

			Console.WriteLine();
			Console.WriteLine("----- 🏘️ -----");
			Console.WriteLine("Vos propriétés :");

			foreach (CasePropriete prop in joueur1.Proprietes)
			{
				Console.WriteLine($"--- 📫 {prop.Nom} {prop.Couleur.GetEmoji()}");
			}
			*/

			// lancer le Jeu

			Jeu monopolyI3 = new Jeu 
				([
					new CasePropriete("Patio", Couleurs.Marron, 20),
					new CasePropriete("Rez de chaussé Bât. G.", Couleurs.Marron, 20),
					new CasePropriete("Rez de chaussé Bât. D.", Couleurs.Marron, 22),
					new CasePropriete("Ascenceur Bât. D.", Couleurs.BleuCiel, 26),
					new CasePropriete("Ascenceur Bât. G.", Couleurs.BleuCiel, 26),
					new CasePropriete("Toilette du RdC", Couleurs.BleuCiel, 28),
					new CasePropriete("Classe Games", Couleurs.Violet, 32),
					new CasePropriete("Classe WEB", Couleurs.Violet, 32),
					new CasePropriete("Classe WAD", Couleurs.Violet, 36)
				]);

			// Ajouter le Joueurs
			monopolyI3.AjouterJoueur("Marwa", Pions.Dino);
			monopolyI3.AjouterJoueur("Dorothée", Pions.Voiture);
			monopolyI3.AjouterJoueur("Leslie", Pions.Chien);
			monopolyI3.AjouterJoueur("Mélusine", Pions.DeACoudre);
			monopolyI3.AjouterJoueur("Emilie", Pions.Cuirasse);
			monopolyI3.AjouterJoueur("Jessica", Pions.Fer);
			monopolyI3.AjouterJoueur("Charifa", Pions.Chapeau);
			monopolyI3.AjouterJoueur("Anaïs", Pions.Brouette);
			monopolyI3.AjouterJoueur("Jenny", Pions.Chaussure);
			monopolyI3.AjouterJoueur("Amalia", Pions.Chien);
			monopolyI3.AjouterJoueur("Debby", Pions.Dino);

			// Lancer le tour
			Joueur joueurCourant = monopolyI3[Pions.Chapeau];
			joueurCourant = joueurCourant + 200;

			Console.WriteLine();
			Console.WriteLine("----- 🎲 -----");
			Console.WriteLine($"C'est au tour de {joueurCourant.Nom} {joueurCourant.Pion.GetEmoji()} !");

			// Faire avancer le joueur
			joueurCourant.Avancer();

			Console.WriteLine();
			Console.WriteLine("----- 📍 -----");
			Console.WriteLine($"{joueurCourant.Pion.GetEmoji()} avancez à la case {joueurCourant.Position}.");

			// Positionner le Joueur
			CasePropriete caseJoueur = monopolyI3[joueurCourant.Position];

			Console.WriteLine();
			Console.WriteLine("----- ℹ️ -----");
			Console.WriteLine($"Bienvenue sur la case 📫 {caseJoueur.Nom}.");

			// Le Joueur achète la case sur laquelle il est
			CasePropriete[] proprietesJoueur = joueurCourant + caseJoueur;

			Console.WriteLine();
			Console.WriteLine("----- 💰 -----");
			Console.WriteLine($"Votre solde est de {joueurCourant.Solde}💲.");
		}
	}
}
