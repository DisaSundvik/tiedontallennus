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
      
            string tiedosto = @"F:\Lampotila.txt";

            //luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu lämpötila on" + aiempiArvo + " astetta. ");
            }
            else
            {
                Console.WriteLine("Tervetuloa! ");
            }

            int Lampotila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            Lampotila = int.Parse(syöte);


            //tiedostoon kirjoittaminen
            File.WriteAllText(tiedosto, Lampotila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu");

            Console.ReadLine();
        }
    }
}
