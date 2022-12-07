using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7
{
    internal class Auto
    {
        public Auto(string CarName, int Speed)
        {
            Marke = CarName;
            PS = Speed;
        }


        int result;
        int currentGear;
        int PS;
        string Marke;

        public int CurrentSpeed
        {
            get { return result; }
            set { result = value; }
        }

        public int CurrentGear
        {
            get { return currentGear; }
            set { currentGear = value; }
        }

        public int P_S
        {
            set { PS = value; }
            get { return PS; }
        }

        public string CarName
        {
            get { return Marke;}
            private set { Marke = value; }
        }


        //Accelerate = PS und jetzigem Speed nur wenn Auto an
        public int GetSpeed(Form1.Mode mode)
        {
            //Kann nur Gas geben wenn Auto an ist
            if (PS == 250)
            {
                if (mode == Form1.Mode.Accelerate && (result + 10) <= 260)
                {
                    result += 10;
                }
                else if (mode == Form1.Mode.Accelerate && (result + 10) >= 260)
                {
                    result = 260;
                }
            }
            else if (PS == 90)
            {
                if (mode == Form1.Mode.Accelerate && (result + 5) <= 238)
                {
                    result += 5;
                }
                else if (mode == Form1.Mode.Accelerate && (result + 5) >= 238)
                {
                    result = 238;
                }
            }
            else if (PS == 370)
            {
                if (mode == Form1.Mode.Accelerate && (result + 15) <= 372)
                {
                    result += 15;
                }
                else if (mode == Form1.Mode.Accelerate && (result + 25) >= 372)
                {
                    result = 372;
                }
            }

            return result;
        }

        //Break = PS und jetzigem Speed immer
        public int GetBreak()
        {
            if (PS == 250)
            {
                if ((result - 15) >= 0)
                {
                    result -= 15;
                }
                else
                {
                    result = 0;
                }
            }
            else if (PS == 90)
            {
                if ((result - 10) >= 0)
                {
                    result -= 10;
                }
                else
                {
                    result = 0;
                }
            }
            else if (PS == 370)
            {
                if ((result - 25) >= 0)
                {
                    result -= 25;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }

        //Gang zuweisung
        public int GetGear()
        {
            if (result > 101)
            {
                currentGear = 6;
            }
            else if (result > 71)
            {
                currentGear = 5;
            }
            else if (result > 41)
            {
                currentGear = 4;
            }
            else if (result > 21)
            {
                currentGear = 3;
            }
            else if (result > 11)
            {
                currentGear = 2;
            }
            else if (result > 0)
            {
                currentGear = 1;
            }

            return currentGear;
        }

        public override string ToString()
        {
            return this.Marke;
        }

    }
}
