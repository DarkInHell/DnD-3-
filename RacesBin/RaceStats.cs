namespace DnD.RacesBin
{
    public class RaceStats
    {
        private int     _pointStr;
        private int     _pointDex;
        private int     _pointVit;
        private int     _pointWit;
        private int     _pointInt;
        private int     _pointCha;
        private string  _nameRace;
        private int     _speed;
        private string  _lang;
        public string[] NameAbility { get; set; }
        public string[] DescriptionAbility {  get; set; }

        public int      PointStr    { get { return _pointStr; } set { _pointStr = value; } }
        public int      PointDex    { get { return _pointDex; } set { _pointDex = value; } }
        public int      PointVit    { get { return _pointVit; } set { _pointVit = value; } }
        public int      PointWit    { get { return _pointWit; } set { _pointWit = value; } }
        public int      PointInt    { get { return _pointInt; } set { _pointInt = value; } }
        public int      PointCha    { get { return _pointCha; } set { _pointCha = value; } }
        public string   NameRace    { get { return _nameRace; } set { _nameRace = value; } }
        public int      Speed       { get { return _speed; }    set { _speed = value; } }
        public string   Lang        { get { return _lang; }     set { _lang = value; } }
    }
}
