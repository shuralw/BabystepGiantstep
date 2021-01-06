using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabystepGiantstep
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Calculus calculus_Aufgabe1 = new Calculus(131, 2, 125, 12);
            Console.WriteLine("Aufgabe a: " + calculus_Aufgabe1.Berechne_a());

            Calculus calculus_Aufgabe2 = new Calculus(2698727, 2, 3, 1643);
            Console.WriteLine("Aufgabe b: " + calculus_Aufgabe2.Berechne_a());
        }

        // Aufgabe a: 8
        // Aufgabe b: 105371
    }
}
