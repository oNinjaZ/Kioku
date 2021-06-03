using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Decks
{
	public class Deck
	{
		public string Name { get; set; }
		public string Id { get; set; }
		private static int deckIdSeeder = 1;
		private List<Card> cardList = new();
		public int CardCount
		{
			get
			{
				return cardList.Count;
			}
		}
		public int KanjiCount
		{
			get
			{
				return cardList.Count(card => card.TypeOfCard == "Kanji");
			}
		}
		public int RadicalCount
		{
			get
			{
				return cardList.Count(card => card.TypeOfCard == "Radical");
			}
		}
		public int VocabCount
		{
			get
			{
				return cardList.Count(card => card.TypeOfCard == "Vocab");
			}
		}
		public Deck(string name)
		{
			Name = name;
			Id = deckIdSeeder.ToString();
			deckIdSeeder++;
		}

		public void AddCard(Card card, string cardName)
		{
			cardList.Add(card);
			Console.WriteLine($"Card [{cardName}], created! Added to Deck [{Name}]");
		}

		public void RemoveCard(string id)
		{
			cardList.Remove(cardList.Find(card => card.Id == id));
		}
		public void PrintCards()
		{
			foreach (var item in cardList)
			{
				item.PrintCardInfo();
			}
		}

		public void PrintDeckInfoShort()
		{
			Console.WriteLine($"Deck Name: {Name}  Cards: {CardCount}\n");
		}
	}
}
