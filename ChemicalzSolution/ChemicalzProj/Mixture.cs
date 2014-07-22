using System;
using System.Collections.Generic;

namespace ChemicalzProj
{
	public class Mixture
	{
		private IList<ISubstance> components;

		public Mixture()
		{
			components = new List<ISubstance>();
		}

		public Mixture AddSubstance(ISubstance substance)
		{
			components.Add(substance);
			return this;
		}
	}
}
