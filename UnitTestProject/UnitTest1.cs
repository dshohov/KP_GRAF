using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShokhovKP;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        string normalFO1 = "4 0 3 4 0 1 4 5 0 1 6 0 3 4 0 1 2 5 0";
        string withSymvolFO = "2 4 6 7 0 3 6 0 2 4 0 3 0 2 0 2 4 0 4 f 0";
        string normalFO2 = "2 4 6 7 0 3 6 0 2 4 0 3 0 2 0 2 4 0 4 0";

        [TestMethod]
        public void TestOtherSymbolInFO()
        {
            FO fo = null;
            try
            {
                fo = new FO(withSymvolFO.Split(' ').Select(x => int.Parse(x)).ToArray());
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void TestNormalFO()
        {
            FO fo = new FO(normalFO1.Split(' ').Select(x => int.Parse(x)).ToArray());
            Assert.IsTrue(fo.CheckRepresentation(fo.fo));
        }
        [TestMethod]
        public void TestNullFO()
        {
            FO fo = null;
            int[] FO = null;
            try
            {
                fo = new FO(FO);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void TestEmptyFO()
        {
            FO fo = null;
            int[] FO = new int[0];
            try
            {
                fo = new FO(FO);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void TestEquivalentGraphs()
        {
            FO fo1 = new FO(normalFO1.Split(' ').Select(x => int.Parse(x)).ToArray());
            FO fo2 = new FO(normalFO1.Split(' ').Select(x => int.Parse(x)).ToArray());

            SetStaticArgument(fo1, fo2);

            CompareGraphs cg = new CompareGraphs(); 
            Assert.AreEqual(true, cg.Compare());
        }
        [TestMethod]
        public void TestNotEquivalentGraphs()
        {
            FO fo1 = new FO(normalFO1.Split(' ').Select(x => int.Parse(x)).ToArray());
            FO fo2 = new FO(normalFO2.Split(' ').Select(x => int.Parse(x)).ToArray());

            SetStaticArgument(fo1, fo2);

            CompareGraphs cg = new CompareGraphs();
            Assert.AreEqual(false, cg.Compare());
        }

        void SetStaticArgument(FO fo1, FO fo2)
        {
            CompareGraphs.FO1 = fo1;
            CompareGraphs.FO2 = fo2;

            GFG gfg1 = new GFG(fo1.Matrix, false);
            CompareGraphs.Clique1 = gfg1.FoundClique();

            GFG gfg2 = new GFG(fo2.Matrix, false);
            CompareGraphs.Clique2 = gfg2.FoundClique();
        }
    }
}
