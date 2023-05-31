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

            foreach (MediaDiscovererCategory val in Enum.GetValues(typeof(MediaDiscovererCategory)))
            {
                Console.WriteLine($"===== {val}  ======");
                var mds = libvlc.MediaDiscoverers(val);

                Console.WriteLine($" number of mds: {mds.Count()}");
                foreach (var dm in mds)
                {
                    Console.WriteLine($"{dm.Category} {dm.Name} {dm.LongName}");
                    //display only disc
                }

                if (mds.Any(x => x.LongName == "Video capture"))
                {
                    var devices = mds.First(x => x.LongName == "Video capture");
                    var md = new MediaDiscoverer(libvlc, devices.Name);
                    md.Start();
                    foreach (var media in md.MediaList)
                    {
                        Console.WriteLine($" _ {media.Mrl}");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}