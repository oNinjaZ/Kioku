using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.UI
{
	public static class Messages
	{
		private static void EditOptions()
		{
			Console.WriteLine("  === Editor ===\n" +
				"  1) Rename a deck\n" +
				"  2) Move card from one deck to another\n" +
				"  3) Edit card");
		}
	}
}
