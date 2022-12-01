using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TannenbaumLibrary
{
    public class Tanne
    {

        int heigth_krone = 0;
        int heigth_stamm = 0;
        int width_stamm = 0;
        string result;

        /// <summary>
        /// Gets or sets the Stammwidth.
        /// </summary>
        public int Stammwidth
        {
            get { return width_stamm; }
            set { width_stamm = value; }
        }

        public int Stammheight
        {
            get { return heigth_stamm; }
            set { heigth_stamm = value; }
        }

        public int Kroeneheight
        {
            get { return heigth_krone; }
            set { heigth_krone = value; }
        }

        public string Drawing
        {
            get { return result; }
            set { result = value; }
        }

        public void Draw()
        {

            result = "";

            if (Stammwidth % 2 == 0)
            {
                width_stamm = Stammwidth + 1;
            }
            else
            {
                width_stamm = Stammwidth;
            }


            for (int i = 1; i <= heigth_krone; i++)
            {

                for (int j = 1; j <= heigth_krone - i; j++)
                    result += " ";

                for (int j = 1; j <= (2 * i - 1); j++)
                    result += "*";

                result += "\r\n";
            }


            for (int i = 0; i < heigth_stamm; i++)
            {
                for (int l = ((width_stamm - 1) / 2) + 1; l < heigth_krone; l++)
                {
                    result += " ";
                }
                result += "*";

                for (int j = 1; j < width_stamm; j++)
                {
                    result += "*";
                }
                result += "\r\n";
            }
            result += "\r\n";
        }
    }
}
