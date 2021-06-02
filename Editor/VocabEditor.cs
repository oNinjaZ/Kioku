using Kioku.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Editor
{
	public static class VocabEditor
	{
		public static void FieldSelector(ref List<Card> cardList, int id)
		{
			Console.WriteLine("Which Field would you like to edit?");
			string field = Console.ReadLine();
			switch (field.ToUpper())
			{
				case "WORD":
					Word(ref cardList, id);
					break;
				case "READING":
					Reading(ref cardList, id);
					break;
				case "MEANING":
					Meaning(ref cardList, id);
					break;
				default:
					Console.WriteLine("Error: Invalid Field");
					break;
			}
		}
		public static void Word(ref List<Card> cardList, int id)
		{
			Console.WriteLine("Enter New Word");
			FindCard(cardList, id).Word = Console.ReadLine();
		}
		public static void Reading(ref List<Card> cardList, int id)
		{
			Console.WriteLine("Enter New Reading");
			FindCard(cardList, id).Reading = Console.ReadLine();
		}
		public static void Meaning(ref List<Card> cardList, int id)
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
