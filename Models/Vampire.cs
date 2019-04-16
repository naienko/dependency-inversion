using System;

namespace dependency_inversion
{
	public class Vampire : IArgentphobic, ICombustable
	{
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