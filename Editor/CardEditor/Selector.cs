using Kioku.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Editor.CardEditor
{
	public static class Selector
	{
		public static void FindCard(Deck deck)
		{
			UI.Display.DisplayCardsShort(deck);
			Console.WriteLine("Type the ID of the card you wish to edit:\n");
			string input = Console.ReadLine();
			if(deck.cardList.Any(card=>card.Id == input))
			{
				var cardToEdit = deck.cardList.Find(card => card.Id == input);
				switch (cardToEdit.TypeOfCard)
				{
					case "Kanji": KanjiEditor.FieldSelector(cardToEdit);
						break;
					case "Vocab":
						break;
					case "Radical":
						break;
					default:
						break;
				}
			}
		}
	}
}
