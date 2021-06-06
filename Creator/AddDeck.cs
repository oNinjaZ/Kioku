using Kioku.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Creator
{
	public static class AddDeck
	{
		public static void Add(List<Deck> deck)
		{
			Console.WriteLine("Enter Deck Name....");
			string deckName = Console.ReadLine();
			deck.Add(new Deck(deckName));
			Console.WriteLine($"Deck [{deckName}], added!");
		}

	}
}
