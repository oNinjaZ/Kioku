using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Decks
{
	class Kanji : Card
	{
		public Kanji(string character, string onyomi, string kunyomi, string meaning)
		{
			Character = character;
			Onyomi = onyomi;
			Kunyomi = kunyomi;
			Meaning = meaning;
			TypeOfCard = "Kanji";
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
		public override void PrintHorizontal()
		{
			Console.WriteLine($"Kanji: {Character}  Kunyomi: {Kunyomi}  Onyomi: {Onyomi}  Meaning: {Meaning}");
		}
		public override void PrintCardInfoNoId()
		{
			Console.WriteLine($"Kanji: {Character}");
		}
	}
}
