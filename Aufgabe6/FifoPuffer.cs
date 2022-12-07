using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7
{
    internal class FifoPuffer
    {
        static int pufferWidth = 1;
        string putstr;
        string getstr;

        public int PufferWidth
        {
            get { return pufferWidth; }
            set { pufferWidth = value; }
        }

        public string PUT
        {
            set { putstr = value; }
        }

        public string GET
        {
            get { return getstr; }
        }



        string[] fifoPuffer = new string[pufferWidth]; 

        public void put()
        {
            fifoPuffer[fifoPuffer.Length+1] = putstr;
        }

        public void get()
        {
            int i = 0;
            string zwischenresult = "";
            foreach (string getabsatz in fifoPuffer)
            {
                
                zwischenresult += fifoPuffer[i];
                i++;
            }
            getstr = zwischenresult;
        }
    }
}
