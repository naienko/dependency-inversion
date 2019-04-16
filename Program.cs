using System;
using System.Collections.Generic;

namespace dependency_inversion
{
	class Program
	{
		static void Main()
		{
			Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

			Mummy tuts = new Mummy();

			VonRimmersmark.Ignite(tuts);

            Demon hellboy = new Demon();

            VonRimmersmark.SplashWater(hellboy);
		}
	}
}
