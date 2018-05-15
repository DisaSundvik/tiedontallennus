using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiedontallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lampotila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            Lampotila = int.Parse(syöte);

            //tiedostoon kirjoittaminen
            string tiedosto = @"F:\Lampotila.txt";

            File.WriteAllText(tiedosto, Lampotila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu");

            Console.ReadLine();
        }
    }
}
