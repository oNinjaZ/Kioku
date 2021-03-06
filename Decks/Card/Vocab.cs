using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Decks
{
	class Vocab : Card
	{
		public Vocab(string word, string reading, string meaning)
		{
			Character = word;
			Reading = reading;
			Meaning = meaning;
			TypeOfCard = "Vocab";
		}

		public override void PrintCardInfo()
		{
			Console.WriteLine($"\nId: {Id}\n" +
				$"Vocab: {Character}\n" +
				$"Reading: {Reading}\n" +
				$"Meaning: {Meaning}");
		}

		public override void PrintCardInfoShort()
		{
			Console.WriteLine($"\nId: {Id}\n" +
				$"Vocab: {Character}\n");
		}

		public override void RemovalMessage()
		{
			Console.WriteLine($"Successfully deleted {Character} [Card ID: {Id}] ");
		}

		public override void PrintCardInfoNoId()
		{
			Console.WriteLine($"Vocab: {Character}");
		}

		public override void PrintHorizontal()
		{
			Console.WriteLine($"Vocab: {Character}  Reading: {Reading}  Meaning: {Meaning}");
		}
	}
}

