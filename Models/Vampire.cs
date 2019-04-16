using System;

namespace dependency_inversion
{
	public class Vampire : Monster, IArgentphobic, ICombustable
	{
		public string typeName { get; } = "Vampire";
		public void Stab()
		{
			Console.WriteLine("You just killed the Vampire");
		}
		public void Burn(string attack) {
			if (attack == "Fire")
			{
				Console.WriteLine("You just killed the Vampire");
			}
		}
	}
}