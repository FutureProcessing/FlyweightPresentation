using System;

namespace ChemicalzProj
{
    public static class Mixtures
    {
        public static Mixture MakeBlackPowder()
        {
            Substance carbon = new Substance(ChemicalFactory.GetChemical(SymbolEnum.CARBON), 15);
            Substance sulfur = new Substance(ChemicalFactory.GetChemical(SymbolEnum.SULFUR), 10);
            Substance saltpetre = new Substance(ChemicalFactory.GetChemical(SymbolEnum.SALTPETRE), 75);

            Mixture blackPowder = new Mixture();
            blackPowder.AddSubstance(carbon).AddSubstance(sulfur).AddSubstance(saltpetre);

            return blackPowder;
        }

        public static Mixture MakeMoreExplosiveBlackPowder()
        {
            Substance carbon = new Substance(ChemicalFactory.GetChemical(SymbolEnum.CARBON), 30);
            Substance sulfur = new Substance(ChemicalFactory.GetChemical(SymbolEnum.SULFUR), 20);
            Substance saltpetre = new Substance(ChemicalFactory.GetChemical(SymbolEnum.SALTPETRE), 150);

            Mixture blackPowder = new Mixture();
            blackPowder.AddSubstance(carbon).AddSubstance(sulfur).AddSubstance(saltpetre);

            return blackPowder;
        }
    }
}

