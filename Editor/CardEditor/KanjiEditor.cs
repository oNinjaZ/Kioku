using Kioku.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Editor
{
	public static class KanjiEditor
	{
		public static void FieldSelector(Card card)
		{
			Console.WriteLine("=== Enter field to edit ===\n" +
				"[Character]  [Onyomi]  [Kunyomi]  [Meaning]");
			string field = Console.ReadLine();
			switch (field.ToUpper())
			{
				case "CHARACTER":
					EditCharacter(card);
					break;
				case "ONYOMI":
					EditOnyomi(card);
					break;
				case "KUNYOMI":
					EditKunyomi(card);
					break;
				case "MEANING":
					EditMeaning(card);
					break;
				default:
					Console.WriteLine("Error: Invalid Field");
					break;
			}
		}
		private static void EditCharacter(Card card)
		{
			Console.WriteLine("Enter new character");
			string newChar = Console.ReadLine();
			card.Character = newChar;
			UI.Display.DisplayEditedCard(card);
		}
		private static void EditOnyomi(Card card)
		{
			Console.WriteLine("Enter New Onyomi");

		}
		private static void EditKunyomi(Card card)
		{
			Console.WriteLine("Enter New Kunyomi");
	
		}
		private static void EditMeaning(Card card)
		{
			Console.WriteLine("Enter New Meaning");

		}

	}
}
