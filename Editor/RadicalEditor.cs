using Kioku.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Editor
{
	public static class RadicalEditor
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
				case "MEANING":
					Meaning(ref cardList, id);
					break;
				default:
					Console.WriteLine("Error: Invalid Field");
					break;
			}
		}
		public static void Character(ref List<Card> cardList, int id)
		{
			Console.WriteLine("Enter New Character");
			FindCard(cardList, id).Character = Console.ReadLine();
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
