using Kioku.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Editor
{
	public static class KanjiEditor
	{
		public static void FieldSelector(ref List<Card> cardList, int id)
		{
			Console.WriteLine("Which Field would you like to edit?");
			string field = Console.ReadLine();
			switch (field.ToUpper())
			{
				case "CHARACTER":
					Character(ref cardList, id);
					break;
				case "ONYOMI":
					Onyomi(ref cardList, id);
					break;
				case "KUNYOMI":
					Kunyomi(ref cardList, id);
					break;
				case "MEANING":
					Meaning(ref cardList, id);
					break;
				default:
					Console.WriteLine("Error: Invalid Field");
					break;
			}
		}
		private static void Character(ref List<Card> cardList, int id)
		{
			Console.WriteLine("Enter New Character");
			FindCard(cardList, id).Character = Console.ReadLine();
		}
		private static void Onyomi(ref List<Card> cardList, int id)
		{
			Console.WriteLine("Enter New Onyomi");
			FindCard(cardList, id).Onyomi = Console.ReadLine();
		}
		private static void Kunyomi(ref List<Card> cardList, int id)
		{
			Console.WriteLine("Enter New Kunyomi");
			FindCard(cardList, id).Kunyomi = Console.ReadLine();
		}
		private static void Meaning(ref List<Card> cardList, int id)
		{
			Console.WriteLine("Enter New Meaning");
			FindCard(cardList, id).Meaning = Console.ReadLine();
		}

		private static Card FindCard(List<Card> cardList, int id)
		{
			return cardList.Find(card => (card.Id == id.ToString()));
		}
	}
}
