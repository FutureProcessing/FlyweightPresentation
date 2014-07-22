using System;

namespace ChemicalzProj
{
	public interface ISubstance
	{
        int Grams
        {
            get;
        }

        string Name
        {
            get;
        }

        SymbolEnum Symbol
        {
            get;
        }

        int AtomicWeight
        {
            get;
        }

        double Moles
        {
            get;
        }
	}
}
    