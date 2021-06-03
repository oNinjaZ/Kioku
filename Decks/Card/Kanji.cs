using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Decks
{
	class Kanji : Card
	{
		public override string TypeOfCard { get; set; } = "Kanji";
		public Kanji(string character, string onyomi, string kunyomi, string meaning)
		{
			Character = character;
			Onyomi = onyomi;
			Kunyomi = kunyomi;
			Meaning = meaning;
		}
		public override void PrintCardInfo()
		{
			Console.WriteLine($"\nId: {Id}\n" +
				$"Kanji: {Character}\n" +
				$"Kunyomi: {Kunyomi}\n" +
				$"Onyomi: {Onyomi}\n" +
				$"Meaning: {Meaning}");
		}
		public override void PrintCardInfoShort()
		{
			Console.WriteLine($"\nId: {Id}\n" +
				$"Kanji: {Character}\n");
		}
		public override void RemovalMessage()
		{
			Console.WriteLine($"Successfully deleted {Character} [Card ID: {Id}] ");
		}
	}
}
