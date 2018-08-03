using System;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.X9;

namespace CorertRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            X9ECParameters bcCurve = NistNamedCurves.GetByName("P-521");
            Console.WriteLine("Hello World!");
        }
    }
}
