using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Cards
{
	class Radical : Card
	{
		public override string TypeOfCard { get; set; } = "Radical";
		public Radical(string character, string meaning)
		{
			Character = character;
			Meaning = meaning;
		}

		public override void PrintCardInfo()
		{
			Console.WriteLine($"\nId: {Id}\n" +
				$"Radical: {Character}\n" +
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
	}
}
