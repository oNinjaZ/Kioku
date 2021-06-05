using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Decks
{
	public class Card
	{
		public string Meaning { get; set; }
		public string Kunyomi { get; set; }
		public string Onyomi { get; set; }
		public string Character { get; set; }
		public string Id { get; set; }
		public string Reading { get; set; }
		private static int cardIdSeeder = 1;
		public virtual string TypeOfCard { get; set; }
		public Card()
		{
			Id = cardIdSeeder.ToString();
			cardIdSeeder++;
		}
		public virtual void PrintCardInfo()
		{
			
		}
		public virtual void PrintCardInfoShort()
		{

		}

		public virtual void RemovalMessage()
		{

		}

		public virtual void PrintHorizontal()
		{
		}
	}
}
