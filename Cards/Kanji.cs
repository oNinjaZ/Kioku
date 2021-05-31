using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ずっと.Cards
{
	class Kanji : Card
	{
		public string Kunyomi { get; }
		public string Onyomi { get; }
		public string Character { get; }
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
				$"Character: {Character}\n" +
				$"Kunyomi: {Kunyomi}\n" +
				$"Onyomi: {Onyomi}\n" +
				$"Meaning: {Meaning}");
		}
	}
}
