﻿using EX01.Enums;
using EX01.Models;

namespace EX01
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
				nom = "Samuel",
				pion = Pions.Dino
			};

			Console.WriteLine($"{j1.nom} c'est votre tour! Bougez le pion {j1.pion} de la case {j1.position}!");

			/* Si le joueur a fait un double */
			if (j1.Avancer())
			{
				Console.WriteLine($"Bravo {j1.nom}! Vous avez fait un double!");
			}

			Console.WriteLine($"{j1.nom} vous êtes à présent sur la case {j1.position}!");
		}
	}

}
