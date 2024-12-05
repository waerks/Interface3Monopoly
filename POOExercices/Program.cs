namespace EX01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Crée un nouveau joueur
			Joueur joueur = new Joueur();

			// Positionne le joueur à la case départ
			joueur.position = 0;

			// Si le joueur a fait un double
			if (joueur.Avancer())
			{
				Console.WriteLine("Double!");
			}

			Console.WriteLine($"Vous avancez à la case {joueur.position}");
		}
	}
}
