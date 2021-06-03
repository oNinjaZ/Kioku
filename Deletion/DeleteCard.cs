using Kioku.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kioku.UI;

namespace Kioku.Deletion
{
	public static class DeleteCard
	{
		public static void Delete(ref List<Deck> deckList)
		{

			Console.WriteLine("Enter Name of Deck you wish to remove card from");
			string deckNameToDelete = Console.ReadLine();
			Display.DisplayCardsShort(deckList, deckNameToDelete);
			Console.WriteLine("Enter Id of card you want to delete from list above...");
			string id = Console.ReadLine();
			FindDeck(ref deckList, deckNameToDelete).RemoveCard(id);
		}

		private static Deck FindDeck(ref List<Deck> decks, string name)
		{
			return decks.Find(deck => deck.Name == name);
		}
	}


}
