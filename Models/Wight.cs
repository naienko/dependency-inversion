using System;

namespace dependency_inversion
{
	public class Wight : IArgentphobic
	{
		public void Stab()
		{
			Console.WriteLine("You just killed the Wight");
		}
	}
}