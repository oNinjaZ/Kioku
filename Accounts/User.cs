using System;
using System.Collections.Generic;
using System.Linq;
using Kioku.Cards;


namespace Kioku.Accounts
{
	public class User
	{
		public string UserName { get; set; }
		public string Id { get; }
		public int Level { get; set; }
		private List<Card> cardList = new List<Card>();
		public bool IsPremium { get; set; }

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


		public User(string username)
		{
			UserName = username;
			IsPremium = false;
			Level = 0;
		}

		public void AddCard()
		{
			Console.WriteLine("Select card type: [Kanji]  [Vocab]  [Radical]");
			string answer = Console.ReadLine().ToUpper();
			Creator.AddCard.ChooseType(ref cardList, answer, IsPremium);
		}

		public void RemoveCard()
		{
			if (cardList.Any())
			{
				CardPropertyShort();
				Console.WriteLine("Enter ID of card you want to remove...");
				int id = int.Parse(Console.ReadLine());
				FindCard(id).RemovalMessage();
				cardList.Remove(FindCard(id));
			}
			else
			{
				Console.WriteLine("Deck Empty...(No Cards To Remove)");
			}
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
				Console.WriteLine("List Empty...(No Cards To Show)");
			}
		}

		public void GoPremium()
		{
			IsPremium = true;
			Console.WriteLine($"Congradulations! {UserName} is a premium user as of {DateTime.Now}");
		}

		public void EditCard()
		{
			if (cardList.Any())
			{
				CardPropertyShort();
				Console.WriteLine("Select Card ID from List Above:");
				int cardId = int.Parse(Console.ReadLine());
				if (FindCard(cardId).TypeOfCard == "Kanji")
				{
					Editor.KanjiEditor.FieldSelector(ref cardList, cardId);
				}
				if (FindCard(cardId).TypeOfCard == "Radical")
				{
					Editor.RadicalEditor.FieldSelector(ref cardList, cardId);
				}
				if (FindCard(cardId).TypeOfCard == "Vocab")
				{
					Editor.VocabEditor.FieldSelector(ref cardList, cardId);
				}
			}
			else
			{
				Console.WriteLine("List Empty...(No Cards To Edit)");
			}
		}

		private Card FindCard(int id)
		{
			return cardList.Find(card => (card.Id == id.ToString()));
		}

		private void CardPropertyShort()
		{
			foreach (var item in cardList)
			{
				item.PrintCardInfoShort();
			}
		}

		public void ViewStats()
		{
			Console.WriteLine($"\nTotal Cards in {UserName}'s Deck...\nRadicals: {RadicalCount}\nKanji: {KanjiCount}\nVocab: {VocabCount}");
		}

	}
}
