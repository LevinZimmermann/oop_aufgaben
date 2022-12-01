using LenovoApiLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenovoApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Lenovo Warranty Lookup - Einzelabfrage [ https://pcsupport.lenovo.com/ch/en/warrantylookup#/ ]");
            Console.WriteLine("**********************************************************************************************\n");

            Console.Write("Seriennummer eingeben: "); // PG01GTB2
            string serial = Console.ReadLine();
       
            MachineInfo mi = Api.GetMachineInfo(serial);

            if (mi != null)
            {
                Console.WriteLine("\n--- Gerät ---\n");
                Console.WriteLine("Produktgruppe: " + mi.ProductGroup);
                Console.WriteLine("Produkt: " + mi.ProductName);
                Console.WriteLine("Modell: " + mi.Model);

                Console.WriteLine("\n--- Aktuelle Garantie ---\n");
                Console.WriteLine("Name: " + mi.CurrentWarranty.Name);
                Console.WriteLine("Kategorie: " + mi.CurrentWarranty.Category);
                Console.WriteLine("Typ: " + mi.CurrentWarranty.Typ);
                Console.WriteLine("Dauer: " + mi.CurrentWarranty.Duration + " Monate");
                Console.WriteLine("Von: " + mi.CurrentWarranty.Start.ToString("dd.MM.yyyy"));
                Console.WriteLine("Bis: " + mi.CurrentWarranty.End.ToString("dd.MM.yyyy"));
                Console.WriteLine("Beschreibung: " + mi.CurrentWarranty.Description);

                Console.WriteLine("\n--- Garantie Upgrade Optionen  ---\n");
                int n = 0;
                foreach (Warranty warranty in mi.UpgradeWarrantyList.WarrantyList)
                {
                    n++;
                    Console.WriteLine("Option " + n);
                    Console.WriteLine("--------");
                    Console.WriteLine("Name: " + warranty.Name);
                    Console.WriteLine("Kategorie: " + warranty.Category);
                    Console.WriteLine("Typ: " + warranty.Typ);
                    Console.WriteLine("Dauer: " + warranty.Duration + " Monate");
                    Console.WriteLine("Von: " + warranty.Start.ToString("dd.MM.yyyy"));
                    Console.WriteLine("Bis: " + warranty.End.ToString("dd.MM.yyyy"));
                    Console.WriteLine("Beschreibung: " + warranty.Description + "\n");
                }
            }
            else
            {
                Console.WriteLine("\nKeine Informationen für eingegebene Seriennummer.");
            }

            Console.ReadKey();
        }
    }
}
