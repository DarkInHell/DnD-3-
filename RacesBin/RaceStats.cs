namespace DnD.RacesBin
{
    public class RaceStats
    {
        private int[] _point;
        private string  _nameRace;
        private int     _speed;
        private string  _lang;
        private string[] _nameAbility;
        private string[] _descriptionAbility;



        public virtual int[]    Point    { get { return _point; } set { _point = value; } }
        public virtual string   NameRace    { get { return _nameRace; } set { _nameRace = value; } }
        public virtual int      Speed       { get { return _speed; }    set { _speed = value; } }
        public virtual string   Lang        { get { return _lang; }     set { _lang = value; } }
        public virtual string[] NameAbility { get { return _nameAbility; } set { _nameAbility = value; } }
        public virtual string[] DescriptionAbility {  get { return _descriptionAbility; } set { _descriptionAbility = value; } }
    }
}
