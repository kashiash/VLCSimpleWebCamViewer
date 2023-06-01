using System.Diagnostics;
using System.Media;
using LibVLCSharp.Shared;

namespace VncConsoleGetAllWebsams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread.Sleep(1000);

       

            // Create a SoundPlayer instance and load the sound file
            PlaySound(@"c:\video\yes.wav");

            Thread.Sleep(1000);
            PlaySound(@"c:\video\no.wav");

            Thread.Sleep(1000);
            PlaySound(@"c:\video\yes.wav");

            Thread.Sleep(1000);
            PlaySound(@"c:\video\no.wav");


            // Wait for the sound to finish playing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

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
            Thread.Sleep(1000);
            PlaySound(@"c:\video\no.wav");
            Thread.Sleep(1000);
            Console.ReadKey();
        

        }

        private static void PlaySound(string soundFilePath)
        {
            SoundPlayer soundPlayer = new SoundPlayer(soundFilePath);

            try
            {
                // Play the sound
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing sound: " + ex.Message);
            }
        }
    }
}