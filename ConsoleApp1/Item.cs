using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Item
    {
        public Item(Media media)
        {
            Media = media;
            Name = media.Meta(MetadataType.Title);
            IsDirectory = media.Type == MediaType.Directory;
            Type = IsDirectory ? "Directory" : "File";
        }

        public string Name { get; private set; }
        public string Type { get; private set; }
        public bool IsDirectory { get; private set; }
        public Media Media { get; set; }
    }

}
