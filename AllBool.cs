using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class AllVariable
    {
        public bool Stats = false;
        public bool DopStats = false;
        public bool MasterBool = false;

        public int StatsNum;
        public int MasterBonus;
        public int SpasPointNum;
        public int LvlPoint;
        public int LvlView;

        public int[] Lvl = new int[] {0, 300, 900, 2700, 6500, 14000, 23000, 34000, 48000, 64000, 85000, 100000, 120000, 140000, 165000, 195000, 225000, 265000, 305000, 355000};
    }
}
