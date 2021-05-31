using System;
using ずっと.Accounts;

namespace ずっと
{
	class Program
	{
		static void Main(string[] args)
		{
			User pubby = new Free("pubby");
			pubby.AddKanji("笑","しょう", "わら","laugh");
			pubby.AddKanji("笑","しょう", "わら","lol");
			pubby.ShowCards();
			pubby.RemoveCard(2);
			pubby.ShowCards();
			Console.WriteLine($"Level: {pubby.Level}");
		}
	}
}
