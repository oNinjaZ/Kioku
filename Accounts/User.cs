using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ずっと.Cards;

namespace ずっと.Accounts
{
	public class User
	{
		public string UserName { get; set; }
		public string Id { get; }
		public int Level { get; set; }
		private List<Card> cardList = new List<Card>();
		public int CardCount
		{
			get
			{
				return cardList.Count;
			}
		}

		public User()
		{
			Level = 0;
		}

		public void AddKanji(string character, string onyomi, string kunyomi, string meaning)
		{
		
			cardList.Add(new Kanji(character, onyomi, kunyomi, meaning));
		}

		public void AddRadical(string name)
		{

		}
		public void AddVocab(string reading, string meaning)
		{

		}

		public void RemoveCard(int id)
		{
			cardList.Remove(cardList.Find(card => (card.Id == id.ToString())));
		}

		public void ShowCards()
		{
			if (cardList.Any())
			{
				foreach (var item in cardList)
				{
					item.PrintCardInfo();
				}
			}
			else
			{
				Console.WriteLine("List Empty");
			}
		}
	}
}
