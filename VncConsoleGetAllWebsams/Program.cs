using System.Diagnostics;
using LibVLCSharp.Shared;

namespace VncConsoleGetAllWebsams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Core.Initialize();

            using var libvlc = new LibVLC();

            var mds = libvlc.MediaDiscoverers(MediaDiscovererCategory.Devices);

            Console.WriteLine($" number of mds: {mds.Count()}");
            foreach (var dm in mds)
            {
                Console.WriteLine(dm);
            }

          

          //  if (mds.Any(x => x.LongName == "Video capture"))
          //  {
                var devices = mds.First(x => x.LongName == "Video capture");
                var md = new MediaDiscoverer(libvlc, devices.Name);
                md.Start();
                foreach (var media1 in md.MediaList)
                {
                    Console.WriteLine($" _ {media1.Mrl}");
                }
          //  }

        }
    }
}