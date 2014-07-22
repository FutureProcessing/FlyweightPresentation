using System;
using System.Collections.Generic;

namespace ChemicalzProj
{
    public class ChemicalFactory
    {
        private static IDictionary<SymbolEnum, Chemical> chemicals = new Dictionary<SymbolEnum, Chemical>();

        static ChemicalFactory()
        {
            chemicals[SymbolEnum.CARBON] = new Chemical(SymbolEnum.CARBON.asString(), SymbolEnum.CARBON, 12);
            chemicals[SymbolEnum.SULFUR] = new Chemical(SymbolEnum.SULFUR.asString(), SymbolEnum.SULFUR, 32);
            chemicals[SymbolEnum.SALTPETRE] = new Chemical(SymbolEnum.SALTPETRE.asString(), SymbolEnum.SALTPETRE, 101);
        }

        public static IChemical GetChemical(SymbolEnum symbol)
        {
            return chemicals[symbol];
        }

        private class Chemical : IChemical
        {
            public Chemical(string name, SymbolEnum symbol, int atomicWeight)
            {
                Name = name;
                Symbol = symbol;
                AtomicWeight = atomicWeight;
            }

            public string Name
            {
                get;
                private set;
            }

            public SymbolEnum Symbol
            {
                get;
                private set;
            }

            public int AtomicWeight
            {
                get;
                private set;
            }

            public double Moles(int grams)
            {
                return grams / AtomicWeight;
            }
        }
    }
}

