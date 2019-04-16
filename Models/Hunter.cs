using System;
using System.Collections.Generic;

namespace dependency_inversion
{
	public class Hunter
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public List<string> Weapons { get; } = new List<string>() {
		"Silver", "Fire", "Holy Water"
	};

		public Hunter(string first, string last)
		{
			FirstName = first;
			LastName = last;
		}

		public void SplashWater(IUnholy monster)
		{
			monster.Douse();  // Kills with holy water
		}

		public void Ignite(ICombustable monster)
		{
			monster.Burn("Fire");  // Kills with fire
		}

		public void WieldSilver(IArgentphobic monster)
		{
			monster.Stab();   // Stabs with silver knife
		}
		public void Destroy(Monster monster)
		{
			monster.Universal();
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
		}
	}
}