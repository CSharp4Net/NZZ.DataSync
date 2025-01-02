using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZZ.DataSync.Logic.Objects.Bases
{
    public abstract class Folder
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ImgKey { get; set; }

        public string Path { get; set; }

        public bool Overwrite { get; set; }

        public bool Ignore { get; set; }
    }
}
