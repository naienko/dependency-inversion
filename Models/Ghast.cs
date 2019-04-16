using System;

namespace dependency_inversion
{
	public class Ghast : Monster, ICombustable, IUnholy
	{
		public string typeName { get; } = "Ghast";
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