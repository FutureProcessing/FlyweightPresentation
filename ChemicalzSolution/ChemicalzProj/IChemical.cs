using System;

namespace ChemicalzProj
{
    public interface IChemical
    {
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

        double Moles(int grams);
    }
}
