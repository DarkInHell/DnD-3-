using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.RacesBin
{
    public class Race : RaceStats
    {
        public Race(int _PointStr, 
                    int _PointDex, 
                    int _PointVit, 
                    int _PointWit, 
                    int _PointInt, 
                    int _PointCha,
                    string _NameRace, 
                    int _Speed, 
                    string _Lang, 
                    string[] _NameAbility, 
                    string[] _DescriptionAbility) 
        {
            PointStr            = _PointStr;
            PointDex            = _PointDex;
            PointVit            = _PointVit;
            PointWit            = _PointWit;
            PointInt            = _PointInt;
            PointCha            = _PointCha;
            NameRace            = _NameRace;
            Speed               = _Speed;
            Lang                = _Lang;
            DescriptionAbility  = _DescriptionAbility;
            NameAbility         = _NameAbility;
        }
    }
}
