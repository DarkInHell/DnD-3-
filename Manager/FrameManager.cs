using System.Windows.Controls;

namespace DnD.Manager
{
    public static class FrameManager
    {
        public static Frame Frame { get; set; }

        private static ChapList _chapList;
        public static ChapList OnlyOneChapList()
        {
            _chapList ??= new ChapList();
            return _chapList;
        }

        private static MapList _mapList;
        public static MapList OnlyOneMapList()
        {
            _mapList ??= new MapList();
            return _mapList;
        }
    }
}
