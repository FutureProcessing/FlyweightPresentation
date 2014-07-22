using System;

namespace ChemicalzProj
{
    public enum SymbolEnum
    {
        CARBON,
        SULFUR,
        SALTPETRE
    }

    public static class ExtensionMethods
    {
        public static String asString(this SymbolEnum symbolEnum)
        {
            switch (symbolEnum)
            {
                case SymbolEnum.CARBON:
                    return "C";
                case SymbolEnum.SULFUR:
                    return "S";
                case SymbolEnum.SALTPETRE:
                    return "KNO3";
            }
            throw new Exception("Not supported symbol");
        }
    }
}
