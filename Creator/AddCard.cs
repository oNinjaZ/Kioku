using Kioku.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Creator
{
	public static class AddCard
	{
		public static void ChooseType(ref List<Deck> decks, string deckName)
		{
			Console.WriteLine("What type of card would you like to add?\n" +
				"Kanji, Radical, or Vocab?");
			var typeToAdd = Console.ReadLine().ToUpper();
			switch (typeToAdd)
			{
				case "KANJI":
					AddKanji(ref decks, deckName);
					break;
				case "VOCAB":
					AddVocab(ref decks, deckName);
					break;
				case "RADICAL":
					AddRadical(ref decks, deckName);
					break;
				default:
					Console.WriteLine("Input Invalid");
					break;
			}
		}

		private static void AddKanji(ref List<Deck> decks, string deckName)
		{
			Console.WriteLine("Enter Character:");
			string character = Console.ReadLine();
			Console.WriteLine("Enter Onyomi:");
			string onyomi = Console.ReadLine();
			Console.WriteLine("Enter Kunyomi:");
			string kunyomi = Console.ReadLine();
			Console.WriteLine("Enter Meaning: ");
			string meaning = Console.ReadLine();

			FindDeck(ref decks, deckName).AddCard(new Kanji(character, onyomi, kunyomi, meaning), character);

		}
		private static void AddRadical(ref List<Deck> decks, string deckName)
		{
			Console.WriteLine("Enter Character:");
			string character = Console.ReadLine();
			Console.WriteLine("Enter Meaning:");
			string meaning = Console.ReadLine();
			
			FindDeck(ref decks, deckName).AddCard(new Radical(character, meaning), character);
		}
		private static void AddVocab(ref List<Deck> decks, string deckName)
		{
			Console.WriteLine("Enter Word:");
			string word = Console.ReadLine();
			Console.WriteLine("Enter Reading:");
			string reading = Console.ReadLine();
			Console.WriteLine("Enter Meaning:");
			string meaning = Console.ReadLine();


			FindDeck(ref decks, deckName).AddCard(new Vocab(word, reading, meaning), word);
		}
		private static void TypeOfCardFull(string type)
		{
			Console.WriteLine($"Maximum Number of {type} Cards Reached (3): Unable to add");
		}

		private static void CardAddedMessage(List<Card> cardList)
		{
			Console.WriteLine($"Card Added! Total: {cardList.Count}");
		}
		private static Deck FindDeck(ref List<Deck> decks, string name)
		{
			return decks.Find(deck => deck.Name == name);
		}

		//private static bool AddSuccess(bool isSuccess)
		//{
		//	return false;
		//}  //todo


		//public static bool AskUpgrade()
		//{
		//	Console.WriteLine("Would you like to upgrade to a premium account for unlimited cards per card-type?\n" +
		//		"Enter (Y) or (N)");
		//	string input = Console.ReadLine();
		//	if (input.ToUpper() == "Y")
		//	{
		//		return false;
		//	}
		//	else
		//	{
		//		Console.WriteLine("Upgrade Failed");
		//	}
		//}
	}
}
