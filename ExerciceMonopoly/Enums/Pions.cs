using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciceMonopoly.Enums
{
	public enum Pions
	{
		Voiture,
		Chien,
		Chapeau,
		Cuirasse,
		Fer,
		Dino,
		DeACoudre,
		Brouette,
		Chaussure
	}

	public static class PionsExtensions
	{
		// Méthode pour récupérer les emojis des pions
		public static string GetEmoji(this Pions pion)
		{
			var emojiPions = new Dictionary<Pions, string>
			{
				{ Pions.Voiture, "🚗" },
				{ Pions.Chien, "🐕" },
				{ Pions.Chapeau, "🎩" },
				{ Pions.Cuirasse, "🛡️" },
				{ Pions.Fer, "🪓" },
				{ Pions.Dino, "🦖" },
				{ Pions.DeACoudre, "🧵" },
				{ Pions.Brouette, "🛒" },
				{ Pions.Chaussure, "👟" }
			};

			return emojiPions.TryGetValue(pion, out string emoji) ? emoji : "❓";
		}
	}
}
