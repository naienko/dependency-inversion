using System;

namespace dependency_inversion {
	public class Demon : IArgentphobic, IUnholy, ICombustable
	{
		public void Stab()
		{
			Console.WriteLine("You just killed the Demon");
		}
		public void Douse()
		{
			Console.WriteLine("You just killed the Demon");
		}
		public void Burn(string attack) {
			if (attack == "Fire")
			{
				Console.WriteLine("You just killed the Demon");
			}
		}
	}
}