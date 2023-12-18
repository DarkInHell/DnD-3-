namespace DnD.RacesBin
{
    public class RaceStats
    {
        protected int[]     _point;
        protected string    _raceName;
        protected int       _speed;
        protected string    _lang;
        protected string[]  _nameAbility;
        protected string[]  _descriptionAbility;

        public int[]    Point    { get { return _point; } set { _point = value; } }
        public string   RaceName    { get { return _raceName; } set { _raceName = value; } }
        public int      Speed       { get { return _speed; }    set { _speed = value; } }
        public string   Lang        { get { return _lang; }     set { _lang = value; } }
        public string[] NameAbility { get { return _nameAbility; } set { _nameAbility = value; } }
        public string[] DescriptionAbility {  get { return _descriptionAbility; } set { _descriptionAbility = value; } }
    }
}
