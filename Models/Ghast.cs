using System;

namespace dependency_inversion
{
	public class Ghast : ICombustable, IUnholy
	{
		public void Burn(string attack) {
			if (attack == "Fire")
			{
				Console.WriteLine("You just killed the Ghast");
			}
		}
		public void Douse()
		{
			Console.WriteLine("You just killed the Ghast");
		}
	}
}