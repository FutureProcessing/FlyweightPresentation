using System;

namespace ChemicalzProj
{
	public class NaiveSubstance : ISubstance
	{
		public NaiveSubstance(string name, SymbolEnum symbol, int atomicWeight, int grams)
		{
			Name = name;
			Symbol = symbol;
			AtomicWeight = atomicWeight;
			Grams = grams;
		}

		public string Name
		{
			get;
			set;
		}

		public SymbolEnum Symbol
		{
			get;
			set;
		}

		public int AtomicWeight
		{
			get;
			set;
		}

		public int Grams
		{
			get;
			set;
		}

		public double Moles
		{
			get
			{
				return Grams / AtomicWeight;
			}
		}
	}
}

