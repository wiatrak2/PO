using System;
using PrimeLib;

class Program
{
    static void Main(string[] args)
    {

System.Console.WriteLine(int.MaxValue);
        PrimeLib.PrimeCollection pc = new PrimeCollection();
        foreach(int p in pc)
				System.Console.WriteLine(p);
    }
}