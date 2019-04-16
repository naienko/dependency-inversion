using System;

namespace dependency_inversion
{
	public class Wight : Monster, IArgentphobic
	{
		public string typeName { get; } = "Wight";
		public void Stab()
		{
			Console.WriteLine("You just killed the Wight");
		}
	}
}