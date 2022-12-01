using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    internal class distanceCalc
    {
        static double speed;
        static double time;
        static int radiobtn;

        public double KM_H
        {
            set { speed = value; }
        }

        public int Radiobtn
        {
            set { radiobtn = value; }
        }
        public double Traveltime
        {
            get { return time; }
        }


        public void GetTravelTime()
        {
            time = 0;
            if (radiobtn == 1)
            {
                time = (Math.Round((384400 / speed)*100))/100;
            }
            else if (radiobtn == 0)
            {
                time = (Math.Round(((384400 / speed) / 24) * 100))/100;
            }
        }
    }
}
