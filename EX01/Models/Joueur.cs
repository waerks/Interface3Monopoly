using EX01.Enums;
using EX01.Models;
using EX01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EX01.Models
{
	public class Joueur
	{
		public string nom;
		public Pions pion;
		public int position;
		public bool Avancer()
		{
			int[] result = De.Lancer(2);
			position += result[0] + result[1];
			return result[0] == result[1];
		}
	}
}
