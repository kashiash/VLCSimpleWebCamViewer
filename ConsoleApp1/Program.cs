// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using LibVLCSharp.Shared;
using System.Collections.ObjectModel;

List<MediaDiscoverer> _mediaDiscoverers = new List<MediaDiscoverer>();
Item _directory;






Console.WriteLine("Hello, World!");
using var libvlc = new LibVLC(enableDebugLogs: true);


foreach (var md in libvlc.MediaDiscoverers(MediaDiscovererCategory.Lan))
{
    var discoverer = new MediaDiscoverer(libvlc, md.Name);
    discoverer.MediaList.ItemAdded += MediaList_ItemAdded;
    discoverer.MediaList.ItemDeleted += MediaList_ItemDeleted;
    discoverer.Start();
    _mediaDiscoverers.Add(discoverer);
}

void MediaList_ItemDeleted(object sender, MediaListItemDeletedEventArgs e)
{
    //var itemToDelete = Items.FirstOrDefault(i => i.Media == e.Media);
    //if (itemToDelete != null)
    //    Items.Remove(itemToDelete);
}


void MediaList_ItemAdded(object sender, MediaListItemAddedEventArgs e)
{
    //Items.Add(new Item(e.Media))
};

void DiscoverNetworkShares() => _mediaDiscoverers.ForEach(md => md.Start());



//https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/TearsOfSteel.mp4
//http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4
//https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/WeAreGoingOnBullrun.mp4
//https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4

//http://commondatastorage.googleapis.com/gtv-videos-bucket

//@"rtsp://10.0.4.123:8554/webcam"
//

using var media = new Media(libvlc, new Uri(@"https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4")); //new Uri(@"D:\gabos\big_buck_bunny.mp4"));
using var mediaplayer = new MediaPlayer(media);

//mediaplayer.Fullscreen = true;
//mediaplayer.EnableHardwareDecoding = true;


mediaplayer.Play();


Console.ReadKey();
