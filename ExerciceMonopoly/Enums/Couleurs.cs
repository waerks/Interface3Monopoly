using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceMonopoly.Enums
{
	public enum Couleurs
	{
		Marron,
		BleuCiel,
		Violet,
		Orange,
		Rouge,
		Jaune,
		Vert,
		Bleu
	}

	public static class CouleurssExtensions
	{
		// Méthode pour récupérer les emojis des pions
		public static string GetEmoji(this Couleurs couleur)
		{
			var emojiPions = new Dictionary<Couleurs, string>
			{
				{ Couleurs.Marron, "🟤" },
				{ Couleurs.BleuCiel, "🔵" },
				{ Couleurs.Violet, "🟣" },
				{ Couleurs.Orange, "🟠" },
				{ Couleurs.Rouge, "🔴" },
				{ Couleurs.Jaune, "🟡" },
				{ Couleurs.Vert, "🟢" },
				{ Couleurs.Bleu, "🔵" },
			};

			return emojiPions.TryGetValue(couleur, out string emoji) ? emoji : "❓";
		}
	}
}
