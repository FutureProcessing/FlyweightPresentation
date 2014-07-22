using System;

namespace ChemicalzProj
{
    public static class NaiveMixtures
    {
        public static Mixture MakeBlackPowder()
        {
            NaiveSubstance carbon = new NaiveSubstance(SymbolEnum.CARBON.asString(), SymbolEnum.CARBON, 12, 15);
            NaiveSubstance sulfur = new NaiveSubstance(SymbolEnum.SULFUR.asString(), SymbolEnum.SULFUR, 32, 10);
            NaiveSubstance saltpetre = new NaiveSubstance(SymbolEnum.SALTPETRE.asString(), SymbolEnum.SALTPETRE, 101, 75);

            Mixture blackPowder = new Mixture();
            blackPowder.AddSubstance(carbon).AddSubstance(sulfur).AddSubstance(saltpetre);

            return blackPowder;
        }

        public static Mixture MakeMoreExplosiveBlackPowder()
        {
            NaiveSubstance carbon = new NaiveSubstance(SymbolEnum.CARBON.asString(), SymbolEnum.CARBON, 12, 30);
            NaiveSubstance sulfur = new NaiveSubstance(SymbolEnum.SULFUR.asString(), SymbolEnum.SULFUR, 32, 20);
            NaiveSubstance saltpetre = new NaiveSubstance(SymbolEnum.SALTPETRE.asString(), SymbolEnum.SALTPETRE, 101, 150);

            Mixture blackPowder = new Mixture();
            blackPowder.AddSubstance(carbon).AddSubstance(sulfur).AddSubstance(saltpetre);

            return blackPowder;
        }
    }
}

