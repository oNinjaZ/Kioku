using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Decks
{
	public abstract class Card
	{
		public string Meaning { get; set; }
		public string Kunyomi { get; set; }
		public string Onyomi { get; set; }
		public string Character { get; set; }
		public string Id { get; set; }
		public string Reading { get; set; }
		private static int cardIdSeeder = 1;
		public string TypeOfCard { get; init; }
		public Card()
		{
			Id = cardIdSeeder.ToString();
			cardIdSeeder++;
		}
		public abstract void PrintCardInfo();
		public abstract void PrintCardInfoShort();
		public abstract void RemovalMessage();
		public abstract void PrintHorizontal();
		public abstract void PrintCardInfoNoId();
	}
}
