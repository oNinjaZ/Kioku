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
		public static void ChooseType(Deck deck)
		{
			Console.WriteLine("Enter type of card to add\n" +
				"Kanji, Radical, or Vocab");
			var typeToAdd = Console.ReadLine().ToUpper();
			switch (typeToAdd)
			{
				case "KANJI":
					AddKanji(deck);
					break;
				case "VOCAB":
					AddVocab(deck);
					break;
				case "RADICAL":
					AddRadical(deck);
					break;
				default:
					Console.WriteLine("Invalid input");
					break;
			}
		}

		private static void AddKanji(Deck deck)
		{
			Console.WriteLine("Enter character:");
			string character = Console.ReadLine();
			Console.WriteLine("Enter onyomi:");
			string onyomi = Console.ReadLine();
			Console.WriteLine("Enter kunyomi:");
			string kunyomi = Console.ReadLine();
			Console.WriteLine("Enter meaning: ");
			string meaning = Console.ReadLine();

			deck.cardList.Add(new Kanji(character, onyomi, kunyomi, meaning));
			CreationSuccess(character, "Kanji", deck.Name);
		}
		private static void AddRadical(Deck deck)
		{
			Console.WriteLine("Enter Character:");
			string character = Console.ReadLine();
			Console.WriteLine("Enter Meaning:");
			string meaning = Console.ReadLine();

			deck.cardList.Add(new Radical(character, meaning));
			CreationSuccess(character, "Radical", deck.Name);
		}
		private static void AddVocab(Deck deck)
		{
			Console.WriteLine("Enter Word:");
			string word = Console.ReadLine();
			Console.WriteLine("Enter Reading:");
			string reading = Console.ReadLine();
			Console.WriteLine("Enter Meaning:");
			string meaning = Console.ReadLine();

			deck.cardList.Add(new Vocab(word, reading, meaning));
			CreationSuccess(word, "Vocab", deck.Name);
		}

		private static void CreationSuccess(string character, string type, string deckName)
		{
			Console.WriteLine($"{type} [{character}] created, and added to {deckName}!");
		}

	}
}
