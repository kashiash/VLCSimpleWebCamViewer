using LibVLCSharp.Shared;

namespace WebCamera
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Core.Initialize();



            using var libVlc = new LibVLC();

            var devices = libVlc.MediaDiscoverers(MediaDiscovererCategory.Devices);
            foreach(var device in devices)
            {
                Console.WriteLine(device.Name);
                var md = new MediaDiscoverer(libVlc, device.Name);
                md.Start();
                foreach (var media in md.MediaList)
                {
                    Console.WriteLine($"{media.NativeReference} {media.Type.ToString()} {media.Statistics}");
                }

            } 


        }
    }
}