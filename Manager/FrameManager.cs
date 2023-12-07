using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DnD.Manager
{
    public static class FrameManager
    {
        public static Frame Frame { get; set; }

        private static ChapList _chapList;
        public static ChapList OnlyOneChapList()
        {
            if (_chapList == null)
            {
                _chapList = new ChapList();
            }
            return _chapList;
        }

        private static MapList _mapList;
        public static MapList OnlyOneMapList()
        {
            if (_mapList == null)
            {
                _mapList = new MapList();
            }
            return _mapList;
        }
    }
}
