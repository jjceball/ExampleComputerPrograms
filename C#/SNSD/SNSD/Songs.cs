using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SNSD
{
    public class Songs
    {
        // Songs Variables
        private string name;
        private string language;
        private bool danceable;

        // Songs
        public string songName
        {
            get { return name; }
            set { name = value; }
        }

        public string songLanguage
        {
            get { return language; }
            set { language = value; }
        }

        public Boolean danceableSong
        {
            get { return danceable; }
            set { danceable = value; }
        }

        public string isDanceable(Boolean b)
        {
            string printDanceable;

            if (b == false)
            {
                printDanceable = "No";
            }
            else
            {
                printDanceable = "Yes";
            }

            return printDanceable;
        }
    }
}
