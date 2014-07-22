using System;

namespace ChemicalzProj
{
    public class Substance : ISubstance
    {
        public Substance(IChemical chemical, int grams)
        {
        }

        private IChemical Chemical
        {
            get;
            set;
        }

        public int Grams
        {
            get;
            set;
        }

        public string Name
        {
            get
            {
                return Chemical.Name;
            }
        }

        public SymbolEnum Symbol
        {
            get
            {
                return Chemical.Symbol;
            }
        }

        public int AtomicWeight
        {
            get
            {
                return Chemical.AtomicWeight;
            }
        }

        public double Moles
        {
            get
            {
                return Chemical.Moles(Grams);
            }
        }
    }
}
    