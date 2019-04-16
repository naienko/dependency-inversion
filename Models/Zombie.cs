using System;

namespace dependency_inversion {
	public class Zombie: Monster, ICombustable
	{
		public string typeName { get; } = "Zombie";
		public void Burn(string attack) {
			if (attack == "Fire")
			{
				Console.WriteLine("You just killed the Zombie");
			}
		}
	}
}