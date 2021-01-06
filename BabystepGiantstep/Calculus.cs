using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<BigInteger> Tinder()
        // Sucht den passenden Partner
        {
            List<BigInteger> matches = new List<BigInteger>();
            List<BigInteger> uWerte = BerechneUWerte();
            List<BigInteger> vWerte = BerechneVWerte();
            List<BigInteger> result = BerechneVWerte();

            matches = uWerte.Intersect(vWerte).ToList();

            int uPos = uWerte.IndexOf(matches.First());
            int vPos = vWerte.IndexOf(matches.First());

            result = new List<BigInteger>() { uPos, vPos };

            return result;
        }
       
        public BigInteger Berechne_a()
        {
            BigInteger uPos = Tinder()[0];
            BigInteger vPos = Tinder()[1];

            BigInteger a = (uPos * m - vPos) % (p-1);
            return a;
        }
    }
}
