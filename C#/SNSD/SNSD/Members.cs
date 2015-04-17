using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SNSD
{
    public class Members
    {
        // Girls Variables
        private string name;
        private int rank;
        public string position;
        public bool funny;

        // Girls
        public string memberName
        {
            get { return name; }
            set { name = value; }
        }

        public int memberRank
        {
            get { return rank; }
            set { rank = value; }
        }

        public string memberPosition
        {
            get { return position; }
            set { position = value; }
        }

        public Boolean funnyMember
        {
            get { return funny; }
            set { funny = value; }
        }

        public string isFunny(Boolean b)
        {
            string printFunny;

            if (b == false)
            {
                printFunny = "No";
            }
            else
            {
                printFunny = "Yes";
            }

            return printFunny;
        }
    }
}
