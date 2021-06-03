using Kioku.Decks;
using Kioku.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Deletion
{
	public static class DeleteDeck
	{
		public static void Delete(ref List<Deck> deckList)
		{
			Console.WriteLine("Enter name of deck you would like to delete");
			string deckToDelete = Console.ReadLine().ToUpper();

			int numOfCardsToDelete = 0;
			Display.DisplayCardsBeforeDelete(deckList, deckToDelete, out numOfCardsToDelete);
			Console.WriteLine($"\nDelete {numOfCardsToDelete} Cards?");

		}
	}
}
