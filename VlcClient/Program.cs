namespace VlcClient
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
             Application.Run(new PlayerForm());
            //var path = @"c:\movies\ElephantsDream.mp4";
            var path = @"d:\gabos\videos\CFNetworkDownload_1aid60.mp4"
;
           // Application.Run(new CustomControlTest(path));
        }
    }
}