using Kioku.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Stats
{
	public static class OvrStats
	{
		public static int TotalCards(List<Deck> deck)
		{
			int total = 0;
			foreach (var item in deck)
			{
				total += item.CardCount;
			}
			return total;
		}
		public static int TotalKanji(List<Deck> deck)
		{
			int total = 0;
			foreach (var item in deck)
			{
				total += item.KanjiCount;
			}
			return total;
		}
		public static int TotalRadical(List<Deck> deck)
		{
			int total = 0;
			foreach (var item in deck)
			{
				total += item.RadicalCount;
			}
			return total;
		}
		public static int TotalVocab(List<Deck> deck)
		{
			int total = 0;
			foreach (var item in deck)
			{
				total += item.VocabCount;
			}
			return total;
		}
	}
}
