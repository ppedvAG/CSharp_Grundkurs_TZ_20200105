using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul003_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Stromrechnung erzeugen:");
            Console.WriteLine("---------------------");
            
            Console.Write("Geben Sie die Kundenummer ein:");
            string kundennummer = Console.ReadLine();
            Console.Write("Geben Sie den Kundennamen ein:");
            string kundenname = Console.ReadLine();
            Console.Write("Geben Sie den Verbrauch ein:");
            int verbrauch = int.Parse(Console.ReadLine());

            decimal preis;
            if (verbrauch >= 600)
            {
                preis = 2; 
            }
            else if(verbrauch >= 400)
            {
                preis = 1.8;
            }
            else if(verbrauch >= 200)
            {
                preis = 1.5; 
            }
            else if(verbrauch >= 0)
            {
                preis = 1.2;
            }

            decimal gesamtpreis = verbrauch * preis;

            Console.WriteLine("\nRechnung:");
            Console.WriteLine($"Kundennummer    :{kundennummer}");
            Console.WriteLine($"Kundenname      :{kundenname}");
            Console.WriteLine($"Verbrauch       :{verbrauch}");
            Console.WriteLine($"Kosten          :{gesamtpreis}");

            Console.ReadLine();
        }
    }
}
