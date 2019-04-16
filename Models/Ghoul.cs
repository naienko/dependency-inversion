using System;

namespace dependency_inversion
{
	public class Ghoul : IUnholy, IArgentphobic
	{
		public void Stab()
		{
			Console.WriteLine("You just killed the Ghoul");
		}
		public void Douse()
		{
			Console.WriteLine("You just killed the Ghoul");
		}
	}
}