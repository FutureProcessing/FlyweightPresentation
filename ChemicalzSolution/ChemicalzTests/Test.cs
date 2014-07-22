using NUnit.Framework;
using System;
using ChemicalzProj;

namespace ChemicalzTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            System.Console.Out.WriteLine("Finished");
            for (int i = 0; i < 20000000; i++)
            {
                Mixture blackPowder = NaiveMixtures.MakeBlackPowder();
                blackPowder.ToString();
            }
            System.Console.Out.WriteLine("Finished");
        }
    }
}

