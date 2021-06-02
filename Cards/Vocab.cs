using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Cards
{
	class Vocab : Card
	{
		public override string TypeOfCard { get; set; } = "Vocab";
		public Vocab(string word, string reading, string meaning)
		{
			Word = word;
			Reading = reading;
			Meaning = meaning;
		}

		public override void PrintCardInfo()
		{
			Console.WriteLine($"\nId: {Id}\n" +
				$"Vocab: {Word}\n" +
				$"Reading: {Reading}\n" +
				$"Meaning: {Meaning}");
		}

		public override void PrintCardInfoShort()
		{
			Console.WriteLine($"\nId: {Id}\n" +
				$"Vocab: {Word}\n");
		}

		public override void RemovalMessage()
		{
			Console.WriteLine($"Successfully deleted {Word} [Card ID: {Id}] ");
		}
	}
}

