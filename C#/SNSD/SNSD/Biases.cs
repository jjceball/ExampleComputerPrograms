using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SNSD
{
    public class Biases
    {
        // Biases Variables
        public string name;
        public int rank;
        public bool wallpaper;
        public string biased;

        // Biases
        public string biasName
        {
            get { return name; }
            set { name = value; }
        }

        public int biasRank
        {
            get { return rank; }
            set { rank = value; }
        }

        public Boolean phoneWallpaper
        {
            get { return wallpaper; }
            set { wallpaper = value; }
        }

        public string onPhone(Boolean b)
        {
            string printWallpaper;

            if (b == false)
            {
                printWallpaper = "No";
            }
            else
            {
                printWallpaper = "Yes";
            }

            return printWallpaper;
        }

        public string whyBias
        {
            get { return biased; }
            set { biased = value; }
        }
    }
}
