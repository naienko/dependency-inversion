using System;

namespace dependency_inversion
{
	public class Mummy : Monster, ICombustable
	{
		public string typeName { get; } = "Mummy";
		public void Burn(string attack)
		{
			if (attack == "Fire")
			{
				Console.WriteLine("You just killed the Mummy");
			}
		}
	}
}