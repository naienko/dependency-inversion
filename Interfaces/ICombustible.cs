using System;
using System.Collections.Generic;

namespace dependency_inversion
{
	public interface ICombustable
	{
		void Burn(string attack);
	}
}