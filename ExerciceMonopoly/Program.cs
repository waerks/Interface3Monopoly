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
			Joueur joueur1 = new Joueur() 
			{
				nom = "Anaïs",
				pion = Pions.Voiture
			};

			Console.WriteLine($"{joueur1.nom} c'est votre tour! Bougez le pion {joueur1.pion.GetEmoji()} de la case {joueur1.position}!");

			// Si le Joueur a fait un double
			if( joueur1.Avancer())
			{
				Console.WriteLine($"Bravo {joueur1.nom}! Vous avez fait un double!");
			}

			Console.WriteLine($"{joueur1.nom} vous êtes à présent sur la case {joueur1.position}!");
		}
	}
}
