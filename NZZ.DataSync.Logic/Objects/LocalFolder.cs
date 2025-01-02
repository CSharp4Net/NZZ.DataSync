using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZZ.DataSync.Logic.Objects
{
    public class LocalFolder : Bases.Folder
    {
        public DateTime LastSync { get; set; }

        public string NetworkPath { get; set; }

        public string SearchPattern { get; set; }
    }
}
