using System;
using System.Collections.Generic;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BabystepGiantstep.Tests
{
    [TestClass]
    public class BabyStepGiantStep_CalculusTests
    {
        [TestMethod]
        public void BerechneUWerte()
        {
            List<BigInteger> expected = new List<BigInteger>() { 1, 35, 46, 38, 20, 45, 3, 105, 7, 114, 60, 4, 9 };

            Calculus calculus = new Calculus();

            List<BigInteger> result = calculus.BerechneUWerte();

            testEachValue(expected, result);
        }

        [TestMethod]
        public void BerechneVWerte()
        {
            List<BigInteger> expected = new List<BigInteger>() { 125, 119, 107, 83, 35, 70, 9, 18, 36, 72, 13, 26, 52 };
            Calculus calculus = new Calculus();

            List<BigInteger> result = calculus.BerechneVWerte();

            testEachValue(expected, result);
        }

        public void testEachValue(List<BigInteger> expected, List<BigInteger> actual)
        {
            for (int i = 0; i < expected.Count - 1; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void GetMatchingPositions()
        {
            List<BigInteger> expected = new List<BigInteger>() { 1, 4 };
            Calculus calculus = new Calculus();

            List<BigInteger> result = calculus.Tinder();

            testEachValue(expected, result);
        }
    }
}