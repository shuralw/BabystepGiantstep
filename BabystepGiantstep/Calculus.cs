using System.Collections.Generic;
using System.Numerics;

namespace BabystepGiantstep
{
    public class Calculus
    {
        BigInteger p = 131, g = 2, A = 125;
        int m = 12;

        public List<BigInteger> BerechneUWerte()
        {
            List<BigInteger> result = new List<BigInteger>() { 1 };

            for (int u = 1; u < m + 1; u++)
            {
                BigInteger temp;
                BigInteger VorherigesErgebnis = result[result.Count - 1];

                temp = VorherigesErgebnis * BigInteger.Pow(g, m) % p;
                result.Add(temp);
            }

            return result;
        }
        public List<BigInteger> BerechneVWerte()
        {
            List<BigInteger> result = new List<BigInteger>() { A };

            for (int v = 1; v < m + 1; v++)
            {
                BigInteger temp;
                BigInteger VorherigesErgebnis = result[result.Count - 1];

                temp = VorherigesErgebnis * g % p;
                result.Add(temp);
            }

            return result;
        }
    }
}
