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
		}
	}
}
