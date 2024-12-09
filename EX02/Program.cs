using EX02.Enums;
using EX02.Models;

namespace EX02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Test class De
            int[] result = De.Lancer(2);
            Console.WriteLine( $"Premier dé : {result[0]}\nSecond dé : {result[1]}");
            */

			/* Test class Joueur */
			Joueur j1 = new Joueur()
			{
				Nom = "Samuel",
				Pion = Pions.Dino
			};

			Console.WriteLine($"{j1.Nom} c'est votre tour! Bougez le pion {j1.Pion} de la case {j1.Position}!");

			/* Si le joueur a fait un double */
			if (j1.Avancer())
			{
				Console.WriteLine($"Bravo {j1.Nom}! Vous avez fait un double!");
			}

			Console.WriteLine($"{j1.Nom} vous êtes à présent sur la case {j1.Position}!");
		}
	}
}
