using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ずっと.Cards
{
	public class Card
	{
		public string Meaning { get; set; }
		public string Id { get; set; }
		private static int cardIdSeeder = 1;
		private static int Count { get; set; }
		public Card()
		{
			Id = cardIdSeeder.ToString();
			cardIdSeeder++;

		}
		public virtual void PrintCardInfo()
		{
			
		}

		public bool isFull()
		{
			return (Count > 9);
		}
	}
}
