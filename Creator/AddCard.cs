using Kioku.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Creator
{
	public static class AddCard
	{
		public static void ChooseType(ref List<Card> cardList, string typeToEdit, bool isPremium)
		{
			switch (typeToEdit)
			{
				case "KANJI":
					if (cardList.Count(card => card.TypeOfCard == "Kanji") < 3 || isPremium)
					{
						AddKanji(ref cardList);
					}
					else
					{
						TypeOfCardFull("Kanji");
					}
					break;
				case "VOCAB":
					if (cardList.Count(card => card.TypeOfCard == "Vocab") < 3 || isPremium)
					{
						AddVocab(ref cardList);
					}
					else
					{
						TypeOfCardFull("Vocab");
					}
					break;
				case "RADICAL":
					if (cardList.Count(card => card.TypeOfCard == "Radical") < 3 || isPremium)
					{
						AddRadical(ref cardList);
					}
					else
					{
						TypeOfCardFull("Radical");
					}
					break;
				default:
					Console.WriteLine("Input Invalid");
					break;
			}
		}

		private static void AddKanji(ref List<Card> cardList)
		{
			Console.WriteLine("Enter Character:");
			string character = Console.ReadLine();
			Console.WriteLine("Enter Onyomi:");
			string onyomi = Console.ReadLine();
			Console.WriteLine("Enter Kunyomi:");
			string kunyomi = Console.ReadLine();
			Console.WriteLine("Enter Meaning: ");
			string meaning = Console.ReadLine();

			cardList.Add(new Kanji(character, onyomi, kunyomi, meaning));
			CardAddedMessage(cardList);
		}
		private static void AddRadical(ref List<Card> cardList)
		{
			Console.WriteLine("Enter Character:");
			string character = Console.ReadLine();
			Console.WriteLine("Enter Meaning:");
			string meaning = Console.ReadLine();

			cardList.Add(new Radical(character, meaning));
			CardAddedMessage(cardList);
		}
		private static void AddVocab(ref List<Card> cardList)
		{
			Console.WriteLine("Enter Word:");
			string word = Console.ReadLine();
			Console.WriteLine("Enter Reading:");
			string reading = Console.ReadLine();
			Console.WriteLine("Enter Meaning:");
			string meaning = Console.ReadLine();


			cardList.Add(new Vocab(word, reading, meaning));
			CardAddedMessage(cardList);
		}
		private static void TypeOfCardFull(string type)
		{
			Console.WriteLine($"Maximum Number of {type} Cards Reached (3): Unable to add");
		}

		private static void CardAddedMessage(List<Card> cardList)
		{
			Console.WriteLine($"Card Added! Total: {cardList.Count}");
		}

		private static bool AddSuccess(bool isSuccess)
		{
			return false;
		}

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
