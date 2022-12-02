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

            Console.Write("Seriennummer eingeben: ");
            string serial = Console.ReadLine();


            // TODO 
            //  - add a reference to the LenovoApiLibrary project 
            //  - include the LenovoApiLibrary-namespace in this projects using section 
            //  - call the static GetMachineInfo()-method of the library's Api class to obtain info 
            //     (use serial number 'PG01GTB2' if you don't have another serial) 
            //  - write obtained information to console 

            Console.ReadKey();
        }
    }
}
